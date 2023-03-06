using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Xml.Linq;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Arduino_FFB_Yoke_App
{

  public partial class Mainform : Form
  {

    private SerialPort SerPort = new SerialPort();
    private Dictionary<string, float> dataList = new Dictionary<string, float>();
    private List<float> val_COUNTER_ROLL = new List<float>();
    private List<float> val_SPEED_ROLL = new List<float>();
    private List<float> val_FORCE_ROLL = new List<float>();
    private List<float> val_COUNTER_PITCH = new List<float>();
    private List<float> val_SPEED_PITCH = new List<float>();
    private List<float> val_FORCE_PITCH = new List<float>();

    public Mainform()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Init Form
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Mainform_Load(object sender, EventArgs e)
    {
      FetchAvailablePorts();  // fill USB Port list
      SetTrackBarToolTips();        // Init Scrolbars
      lbStatus.Text = "Diconnected";
      tb_button_calibration_black.Visible = true;
      tb_sensor_left_black.Visible = true;
      tb_sensor_right_black.Visible = true;
      tb_sensor_up_black.Visible = true;
      tb_sensor_down_black.Visible = true;

      tb_button_calibration_green.Visible = false;
      tb_sensor_left_green.Visible = false;
      tb_sensor_right_green.Visible = false;
      tb_sensor_up_green.Visible = false;
      tb_sensor_down_green.Visible = false;

      tabPageMainSettingsRoll.Enabled = false;
      tabPageMainSettingsPitch.Enabled = false;

    }


    /// <summary>
    /// Get the list of USB Ports and put it into a combobox
    /// </summary>
    void FetchAvailablePorts()
    {
      try
      {
        cbAvailablePortsBox.Items.Clear();
        String[] ports = SerialPort.GetPortNames();     //Put the name of the available USB ports into the ports string array
        if (ports.Length == 0)
        {
          MessageBox.Show("No USB Ports found.", "Error on set USB Ports");
        }


        cbAvailablePortsBox.Items.AddRange(ports);        //Add the string into the dropdown list we made
        if (cbAvailablePortsBox.Items.Count > 0)
        {
          cbAvailablePortsBox.SelectedIndex = 0;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error on set USB Ports");
      }
    }

    /// <summary>
    /// Connect to Yoke
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ConnectToPort_Click(object sender, EventArgs e)
    {

      // is something selected on portlist?
      if (String.IsNullOrEmpty(cbAvailablePortsBox.Text))
      {
        MessageBox.Show("Please select a valid USB Port from List.", "Error on connection to Yoke");
        return;
      }

      // disbale buttons
      this.btConnectToPort.Enabled = false;
      this.cbAvailablePortsBox.Enabled = false;
      this.btRefreshPortList.Enabled = false;


      // create serial port object
      SerPort = new SerialPort();
      SerPort.BaudRate = 115200;
      SerPort.PortName = cbAvailablePortsBox.Text;
      SerPort.Parity = Parity.None;
      SerPort.DataBits = 8;
      SerPort.StopBits = StopBits.One;
      SerPort.RtsEnable = true;
      SerPort.DtrEnable = true;
      SerPort.DataReceived += new SerialDataReceivedEventHandler(DataReceived);

      try
      {
        lbStatus.Text = "Connect to Port:" + cbAvailablePortsBox.Text;
        SerPort.Open();                                                   // open the port
        Thread.Sleep(1000);                                               // wait a sec
        lbStatus.Text = "Connected";
        ReadAllDataFromYoke();
        // this.EnableButtons(true);                                         // enable buttons
        btDebugStart.Enabled = true;
      }
      catch (Exception ex) // error
      {
        MessageBox.Show(ex.Message, "Error on connection to Yoke");       // show message
        this.EnableButtons(false);                                        // enable buttons
        this.btConnectToPort.Enabled = true;
        this.cbAvailablePortsBox.Enabled = true;
        this.btRefreshPortList.Enabled = true;
        btDebugStart.Enabled = false;
      }
    }

    /// <summary>
    /// Data Received from Yoke
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      try
      {
        // read data
        SerialPort spL = (SerialPort)sender;
        string data = spL.ReadLine();

        // is empty?
        if (String.IsNullOrEmpty(data) && data.Length > 3)
          return;

        // is command letter available?
        if (data.Substring(0, 1) != "!")
          return;

        // is command value splitter available?
        if (!data.Contains("|"))
          return;

        // split command and values
        string[] lines = data.Replace("!", "").Split('|');

        // check
        if (lines == null || lines.Length != 2 || String.IsNullOrEmpty(lines[0]) || String.IsNullOrEmpty(lines[1]))
        {
          return;
        }

        // process data
        this.Invoke((MethodInvoker)delegate ()
        {
          ProcessCommand(lines[0], lines[1]);
        });
      }
      catch { }
    } //DataReceived

    /// <summary>
    /// End Application
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
    {
      CloseUsbPort();
    } //Mainform_FormClosing


    /// <summary>
    /// Button refresh USB Port List
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btRefreshPortList_Click(object sender, EventArgs e)
    {
      FetchAvailablePorts();
    } //btRefreshPortList_Click


    /// <summary>
    /// Exit Application 
    /// </summary>
    private void CloseApplication()
    {
      CloseUsbPort();
      Application.Exit();
    } //CloseApplication


    /// <summary>
    /// Close USB Port
    /// </summary>
    private void CloseUsbPort()
    {
      try
      {
        if (SerPort != null && SerPort.IsOpen)
          SerPort.Close(); //close the port on from closing
      }
      catch
      {
      }
      lbStatus.Text = "Diconnected";
    } //CloseUsbPort


    /// <summary>
    /// Enable or disable buttons
    /// </summary>
    /// <param name="status"></param>
    private void EnableButtons(Boolean status)
    {
      this.btDisconnect.Enabled = status;
      this.tabPageMainSettingsPitch.Enabled = status;
      this.tabPageMainSettingsRoll.Enabled = status;

      this.btSettingsReadFromYoke.Enabled = status;
      //this.btSettingsWriteToYoke.Enabled = status;
      this.btSettingsWriteToEEProm.Enabled = status;
      this.btSettingsClearEeprom.Enabled = status;
    }

    /// <summary>
    /// Read Settings form Yoke Button click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btSettingsReadFromYoke_Click(object sender, EventArgs e)
    {
      ReadAllDataFromYoke();
    }

    private void ReadAllDataFromYoke()
    {
      // disable buttons
      this.EnableButtons(false);
      btSettingsWriteToYoke.Enabled = false;
      this.btDisconnect.Enabled = false;
      lbStatus.Text = "Send command to Yoke";
      // send command to yoke
      SendSerialCommand(Constants.SERIAL_CMD_ALL_PARAMS, 0);
      // enabe timeout timer
      lbStatus.Text = "Wait for Data..";
      timerReplySettingsTimeout.Enabled = true;
    }

    /// <summary>
    /// Send string to serial port
    /// </summary>
    /// <param name="command"></param>
    /// <param name="value"></param>
    private void SendSerialCommand(int command, int value)
    {
      try
      {
        // build command string
        string output = "!" + command.ToString() + "|" + value;
        // send to port
        SerPort.Write(output);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error on Send to Serial Port");
      }
    }

    /// <summary>
    /// Quick clicked on menu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CloseApplication();
    }



    /// <summary>
    /// Button debug start clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btDebugStart_Click(object sender, EventArgs e)
    {
      lbStatus.Text = "Start Debug";
      SendSerialCommand(Constants.SERIAL_CMD_DEBUG_START, 0);
    }

    /// <summary>
    /// Button debug stop clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btDebugStop_Click(object sender, EventArgs e)
    {
      lbStatus.Text = "Stop Debug";
      SendSerialCommand(Constants.SERIAL_CMD_DEBUG_STOP, 0);
    }

    /// <summary>
    /// Button disconnect clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btDisconnect_Click(object sender, EventArgs e)
    {
      lbStatus.Text = "Diconnect..";
      // close usb connection
      CloseUsbPort();
      // enable or disbale buttons
      this.EnableButtons(false);
      // refresh usb port list
      FetchAvailablePorts();
      // enable or disbale buttons
      this.btConnectToPort.Enabled = true;
      this.cbAvailablePortsBox.Enabled = true;
      this.btRefreshPortList.Enabled = true;
      this.btDebugStart.Enabled=false;
    }

    /// <summary>
    /// Timer tick for timeout receiving settings data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timerReplySettingsTimeout_Tick(object sender, EventArgs e)
    {
      timerReplySettingsTimeout.Enabled = false;
      MessageBox.Show("Timeout on reading data.", "Error");
      // enable or disbale buttons
      this.EnableButtons(true);
      this.btDisconnect.Enabled = true;
    }


    /// <summary>
    /// Send the adjusted Settingss to Yoke
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btSettingsWriteToYoke_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult = MessageBox.Show("Do you really want to write this Settingss to yoke?", "Write Settingss to Yoke", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.No)
      { 
        return;
      }

      this.EnableButtons(false);
      lbStatus.Text = "Send Data to Yoke";

      // only changed data should be send to Yoke to spend time.
      if (GetData("tb_ROLL_FORCE_MAX") != tb_ROLL_FORCE_MAX.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_FORCE_MAX, tb_ROLL_FORCE_MAX.Value);
      if (GetData("tb_ROLL_PWM_MIN") != tb_ROLL_PWM_MIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_PWM_MIN, tb_ROLL_PWM_MIN.Value);
      if (GetData("tb_ROLL_PWM_MAX") != tb_ROLL_PWM_MAX.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_PWM_MAX, tb_ROLL_PWM_MAX.Value);

      if (GetData("tb_ROLL_FRICTION_MAX_POSITION_CHANGE") != tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_FRICTION_MAX_POSITION_CHANGE, tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Value);
      if (GetData("tb_ROLL_INERTIA_MAX_ACCELERATION") != tb_ROLL_INERTIA_MAX_ACCELERATION.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_INERTIA_MAX_ACCELERATION, tb_ROLL_INERTIA_MAX_ACCELERATION.Value);
      if (GetData("tb_ROLL_DAMPER_MAX_VELOCITY") != tb_ROLL_DAMPER_MAX_VELOCITY.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_DAMPER_MAX_VELOCITY, tb_ROLL_DAMPER_MAX_VELOCITY.Value);

      if (GetData("tb_ROLL_TOTAL_GAIN") != tb_ROLL_TOTAL_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_TOTAL_GAIN, tb_ROLL_TOTAL_GAIN.Value);
      if (GetData("tb_ROLL_CONSTANT_GAIN") != tb_ROLL_CONSTANT_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_CONSTANT_GAIN, tb_ROLL_CONSTANT_GAIN.Value);
      if (GetData("tb_ROLL_RAMP_GAIN") != tb_ROLL_RAMP_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_RAMP_GAIN, tb_ROLL_RAMP_GAIN.Value);
      if (GetData("tb_ROLL_SQUARE_GAIN") != tb_ROLL_SQUARE_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_SQUARE_GAIN, tb_ROLL_SQUARE_GAIN.Value);
      if (GetData("tb_ROLL_SIN_GAIN") != tb_ROLL_SIN_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_SINE_GAIN, tb_ROLL_SIN_GAIN.Value);
      if (GetData("tb_ROLL_TRIANGLE_GAIN") != tb_ROLL_TRIANGLE_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_TRIANGLE_GAIN, tb_ROLL_TRIANGLE_GAIN.Value);
      if (GetData("tb_ROLL_SAWTOOT_DOWN_GAIN") != tb_ROLL_SAWTOOT_DOWN_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_SAWTOOTH_DOWN_GAIN, tb_ROLL_SAWTOOT_DOWN_GAIN.Value);
      if (GetData("tb_ROLL_SAWTOOTH_UP_GAIN") != tb_ROLL_SAWTOOTH_UP_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_SAWTOOTH_UP_GAIN, tb_ROLL_SAWTOOTH_UP_GAIN.Value);
      if (GetData("tb_ROLL_SPRING_GAIN") != tb_ROLL_SPRING_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_SPRING_GAIN, tb_ROLL_SPRING_GAIN.Value);
      if (GetData("tb_ROLL_DAMPER_GAIN") != tb_ROLL_DAMPER_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_DAMPER_GAIN, tb_ROLL_DAMPER_GAIN.Value);
      if (GetData("tb_ROLL_INERTIA_GAIN") != tb_ROLL_INERTIA_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_INERTIA_GAIN, tb_ROLL_INERTIA_GAIN.Value);
      if (GetData("tb_ROLL_FRICTION_GAIN") != tb_ROLL_FRICTION_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_ROLL_FRICTION_GAIN, tb_ROLL_FRICTION_GAIN.Value);


      if (GetData("tb_PITCH_FORCE_MAX") != tb_PITCH_FORCE_MAX.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_FORCE_MAX, tb_PITCH_FORCE_MAX.Value);
      if (GetData("tb_PITCH_PWM_MIN") != tb_PITCH_PWM_MIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_PWM_MIN, tb_PITCH_PWM_MIN.Value);
      if (GetData("tb_PITCH_PWM_MAX") != tb_PITCH_PWM_MAX.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_PWM_MAX, tb_PITCH_PWM_MAX.Value);

      if (GetData("tb_PITCH_FRICTION_MAX_POSITION_CHANGE") != tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_FRICTION_MAX_POSITION_CHANGE, tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Value);
      if (GetData("tb_PITCH_INERTIA_MAX_ACCELERATION") != tb_PITCH_INERTIA_MAX_ACCELERATION.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_INERTIA_MAX_ACCELERATION, tb_PITCH_INERTIA_MAX_ACCELERATION.Value);
      if (GetData("tb_PITCH_DAMPER_MAX_VELOCITY") != tb_PITCH_DAMPER_MAX_VELOCITY.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_DAMPER_MAX_VELOCITY, tb_PITCH_DAMPER_MAX_VELOCITY.Value);

      if (GetData("tb_PITCH_TOTAL_GAIN") != tb_PITCH_TOTAL_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_TOTAL_GAIN, tb_PITCH_TOTAL_GAIN.Value);
      if (GetData("tb_PITCH_CONSTANT_GAIN") != tb_PITCH_CONSTANT_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_CONSTANT_GAIN, tb_PITCH_CONSTANT_GAIN.Value);
      if (GetData("tb_PITCH_RAMP_GAIN") != tb_PITCH_RAMP_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_RAMP_GAIN, tb_PITCH_RAMP_GAIN.Value);
      if (GetData("tb_PITCH_SQUARE_GAIN") != tb_PITCH_SQUARE_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_SQUARE_GAIN, tb_PITCH_SQUARE_GAIN.Value);
      if (GetData("tb_PITCH_SIN_GAIN") != tb_PITCH_SIN_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_SINE_GAIN, tb_PITCH_SIN_GAIN.Value);
      if (GetData("tb_PITCH_TRIANGLE_GAIN") != tb_PITCH_TRIANGLE_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_TRIANGLE_GAIN, tb_PITCH_TRIANGLE_GAIN.Value);
      if (GetData("tb_PITCH_SAWTOOT_DOWN_GAIN") != tb_PITCH_SAWTOOT_DOWN_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_SAWTOOTH_DOWN_GAIN, tb_PITCH_SAWTOOT_DOWN_GAIN.Value);
      if (GetData("tb_PITCH_SAWTOOTH_UP_GAIN") != tb_PITCH_SAWTOOTH_UP_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_SAWTOOTH_UP_GAIN, tb_PITCH_SAWTOOTH_UP_GAIN.Value);
      if (GetData("tb_PITCH_SPRING_GAIN") != tb_PITCH_SPRING_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_SPRING_GAIN, tb_PITCH_SPRING_GAIN.Value);
      if (GetData("tb_PITCH_DAMPER_GAIN") != tb_PITCH_DAMPER_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_DAMPER_GAIN, tb_PITCH_DAMPER_GAIN.Value);
      if (GetData("tb_PITCH_INERTIA_GAIN") != tb_PITCH_INERTIA_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_INERTIA_GAIN, tb_PITCH_INERTIA_GAIN.Value);
      if (GetData("tb_PITCH_FRICTION_GAIN") != tb_PITCH_FRICTION_GAIN.Value) SendSerialCommand(Constants.SERIAL_CDM_WRITE_PITCH_FRICTION_GAIN, tb_PITCH_FRICTION_GAIN.Value);

      // reset label colors
      ResetAllTrackbarLabelColors();
      // read data from yoke again
      ReadAllDataFromYoke();
    }

    /// <summary>
    /// Store the Settingss to EEPROM to make it persitent
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btSettingsWriteToEEProm_Click(object sender, EventArgs e)
    {
      DialogResult dialogResult = MessageBox.Show("Do you really want to store Settingss to EEPROM?", "Store Settingss to EEPROM", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.No)
      {
        return;
      }

      this.EnableButtons(false);
      lbStatus.Text = "Write to EEPROM";
      SendSerialCommand(Constants.SERIAL_CMD_WRITE_DATA_EEPROM, 0);
    }

    /// <summary>
    /// Clear EEPROM of Yoke (delete settings load defaults)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btSettingsClearEeprom_Click(object sender, EventArgs e)
    {

      DialogResult dialogResult = MessageBox.Show("Do you really want to clear EEPROM Settingss of Yoke?", "Clear Data", MessageBoxButtons.YesNo);
      if (dialogResult == DialogResult.No)
      {
        return;
      }

      this.EnableButtons(false);
      lbStatus.Text = "Clear EEPROM...";
      SendSerialCommand(Constants.SERIAL_CMD_WRITE_EEPROM_CLEAR, 0);
    }

    /// <summary>
    /// Set all Labels for Trackbars back to black color
    /// </summary>
    private void ResetAllTrackbarLabelColors()
    {
      try
      {
        foreach (System.Windows.Forms.Label l in GetAll(this, typeof(System.Windows.Forms.Label)))
        {
          if (l.Name.Contains("lb_ROLL_") || l.Name.Contains("lb_PITCH_"))
            l.ForeColor = Color.Black;
        }
      }
      catch { }
    }

    /// <summary>
    /// get all controls of specific type (inclusive childs)
    /// </summary>
    /// <param name="control"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public IEnumerable<Control> GetAll(Control control, Type type)
    {
      var controls = control.Controls.Cast<Control>();

      return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                .Concat(controls)
                                .Where(c => c.GetType() == type);
    }

    /// <summary>
    /// if a trackbar value will change the label color will change to red
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void tb_ValueChanged(object sender, EventArgs e)
    {
      try
      {
        System.Windows.Forms.TrackBar myTrack = (System.Windows.Forms.TrackBar)sender;
        string myLabelName = myTrack.Name.Replace("tb_", "lb_");

        System.Windows.Forms.Label myLabel = (System.Windows.Forms.Label)this.Controls.Find(myLabelName, true).First();
        if (myLabel == null)
          return;

        if (GetData(myTrack.Name) != myTrack.Value)
        {
          myLabel.ForeColor = Color.Red;
          btSettingsWriteToYoke.Enabled=true;
        }
        else
        {
          myLabel.ForeColor = Color.Black;
        }
      }
      catch { }
    }

  }// class

}// namespace