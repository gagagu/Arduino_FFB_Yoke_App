using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Arduino_FFB_Yoke_App
{
  public partial class Mainform : Form
  {

    /// <summary>
    /// Data class for decode received data
    /// </summary>
    public class DataEntry
    {
      public DataEntry(string number, string value)
      {
        Number = number;
        Value = value;
      }
      public string Number { get; set; }
      public string Value { get; set; }

      public int GetValue()
      {
        try
        {
          return Convert.ToInt32(Value)
;
        }
        catch
        {
          return 0;
        }
      }
    }

    /// <summary>
    /// process command received from yoke
    /// </summary>
    /// <param name="command"></param>
    /// <param name="value"></param>
    public void ProcessCommand(string command, string value)
    {
      try
      {
        if (String.IsNullOrEmpty(command) || String.IsNullOrEmpty(value))
        {
          return;
        }

        int iCmd = Convert.ToInt32(command);
        if (iCmd == 0)
          return;

        string[] lines = value.Split(',');
        if (lines == null || lines.Length == 0)
          return;

        // split data an put it into the data structure
        List<DataEntry> data = new List<DataEntry>();
        foreach (string entry in lines)
        {
          string[] tmp = entry.Split(':');
          if (tmp != null && tmp.Length == 2)
          {
            data.Add(new DataEntry(tmp[0], tmp[1]));
          }
        }

        lbStatus.Text = "Process data...";

        // swtich by specific command
        switch (iCmd)
        {
          case Constants.SERIAL_CMD_DEBUG_START:      // debug mode on
            SetDebugStart();
            break;
          case Constants.SERIAL_CMD_DEBUG_STOP:       // debug mode off
            SetDebugStop();
            break;
          case Constants.SERIAL_CMD_DEBUG_VALUES:     // receive debug data
            lbStatus.Text = "Debug Data received " + DateTime.Now.ToLongTimeString();
            SetDebugStart();
            ReadAllValues(data, 0);
            ReadAllParams(data, 42);
            UpdateDebugControls();
            UpdateParamControls();
            break;
          case Constants.SERIAL_CMD_ALL_VALUES:       // read the values (buttons, counters,...)
            ReadAllValues(data, 0);
            UpdateDebugControls();
            break;
          case Constants.SERIAL_CMD_ALL_PARAMS:       // read settings like gains, effects
            timerReplySettingsTimeout.Enabled = false;
            ReadAllParams(data, 0);
            UpdateParamControls();
            SetTrackBarToolTips();
            this.EnableButtons(true);
            this.btDisconnect.Enabled = true;
            lbStatus.Text = "Ready";
            break;
          case Constants.SERIAL_CMD_WRITE_DATA_EEPROM:  // write to eeprom
            lbStatus.Text = "EEPROM written";
            this.EnableButtons(true);
            break;
          case Constants.SERIAL_CMD_WRITE_EEPROM_CLEAR: // clear eeprom
            lbStatus.Text = "EEPROM cleared";
            this.EnableButtons(true);
            break;
          default:   
            if(iCmd>= Constants.SERIAL_CDM_WRITE_ROLL_FORCE_MAX || iCmd<=Constants.SERIAL_CDM_WRITE_PITCH_FRICTION_GAIN){  // data written
              lbStatus.Text = "Finished";
              this.EnableButtons(true);
            }
            break;
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error on process command from Yoke");
      }
    } //ProcessCommand


    /// <summary>
    /// Button handling on debug start
    /// </summary>
    private void SetDebugStart()
    {
      btDebugStart.Enabled = false;
      btDebugStop.Enabled = true;
      EnableButtons(false);
    }

    /// <summary>
    /// Button handling on debug off
    /// </summary>
    private void SetDebugStop()
    {
      btDebugStart.Enabled = true;
      btDebugStop.Enabled = false;
      EnableButtons(true);
    }

    /// <summary>
    /// Store received values into list
    /// </summary>
    /// <param name="data"></param>
    /// <param name="startIndex"></param>
    private void ReadAllValues(List<DataEntry> data, int startIndex)
    {
      try
      {

        if (data == null || data.Count == 0)
          return;

        foreach (DataEntry entry in data)
        {
          switch (Convert.ToInt32(entry.Number) - startIndex)
          {
            case 0:
              SetData("cb_yoke_0", entry.Value);
              break;
            case 1:
              SetData("cb_yoke_1", entry.Value);
              break;
            case 2:
              SetData("cb_yoke_2", entry.Value);
              break;
            case 3:
              SetData("cb_yoke_3", entry.Value);
              break;
            case 4:
              SetData("cb_yoke_4", entry.Value);
              break;
            case 5:
              SetData("cb_yoke_5", entry.Value);
              break;
            case 6:
              SetData("cb_yoke_6", entry.Value);
              break;
            case 7:
              SetData("cb_yoke_7", entry.Value);
              break;
            case 8:
              SetData("cb_yoke_8", entry.Value);
              break;
            case 9:
              SetData("cb_yoke_9", entry.Value);
              break;
            case 10:
              SetData("cb_yoke_10", entry.Value);
              break;
            case 11:
              SetData("cb_yoke_11", entry.Value);
              break;
            case 12:
              SetData("cb_yoke_12", entry.Value);
              break;
            case 13:
              SetData("cb_yoke_13", entry.Value);
              break;
            case 14:
              SetData("cb_yoke_14", entry.Value);
              break;
            case 15:
              SetData("cb_yoke_15", entry.Value);
              break;
            case 16:  // down sensor
              SetData("tb_sensor_down", entry.Value);
              break;
            case 17: // up sensor
              SetData("tb_sensor_up", entry.Value);
              break;
            case 18: // left sensor
              SetData("tb_sensor_left", entry.Value);
              break;
            case 19: // right sensor
              SetData("tb_sensor_right", entry.Value);
              break;
            case 20: // calibration button
              SetData("tb_button_calibration", entry.Value);
              break;
            case 21: // reserved
              SetData("reserved_1", entry.Value);
              break;
            case 22: // reserved
              SetData("reserved_2", entry.Value);
              break;
            case 23: // reserved
              SetData("reserved_3", entry.Value);
              break;
            case 24: // reserved
              SetData("reserved_4", entry.Value);
              break;
            case 25: // reserved
              SetData("reserved_5", entry.Value);
              break;
            case 26: // reserved
              SetData("reserved_6", entry.Value);
              break;
            case 27: // reserved
              SetData("reserved_7", entry.Value);
              break;
            case 28: // reserved
              SetData("reserved_8", entry.Value);
              break;
            case 29: // reserved
              SetData("reserved_9", entry.Value);
              break;
            case 30: // reserved
              SetData("reserved_10", entry.Value);
              break;
            case 31: // reserved
              SetData("reserved_11", entry.Value);
              break;
            case 32: // JOYSTICK_minX
              SetData("iCalibratedRollMin", entry.Value);
              break;
            case 33: // JOYSTICK_maxX
              SetData("iCalibratedRollMax", entry.Value);
              break;
            case 34: // counterRoll
              SetData("val_COUNTER_ROLL", entry.Value);
              break;
            case 35: // roll_speed
              SetData("val_SPEED_ROLL", entry.Value);
              //SetMinMaxLineChart(entry.Value, val_SPEED_ROLL, ref chart_SPEED_ROLL, tb_ROLL_PWM_MIN.Value, tb_ROLL_PWM_MAX.Value);
              break;
            case 36: //  forces[MEM_ROLL]
              SetData("val_FORCE_ROLL", entry.Value);
              //SetMinMaxLineChart(entry.Value, val_FORCE_ROLL, ref chart_FORCE_ROLL, tb_ROLL_FORCE_MAX.Value * (-1), tb_ROLL_FORCE_MAX.Value);
              break;
            case 37: // JOYSTICK_minY
              SetData("iCalibratedPitchMin", entry.Value);
              break;
            case 38: // JOYSTICK_maxY
              SetData("iCalibratedPitchMax", entry.Value);
              break;
            case 39: // counterPitch
              SetData("val_COUNTER_PITCH", entry.Value);
              //SetMinMaxLineChart(entry.Value, val_COUNTER_PITCH, ref chart_COUNTER_PITCH, iCalibratedPitchMin, iCalibratedPitchMax);
              break;
            case 40: // pitch_speed
              SetData("val_SPEED_PITCH", entry.Value);
              //SetMinMaxLineChart(entry.Value, val_SPEED_PITCH, ref chart_SPEED_PITCH, tb_PITCH_PWM_MIN.Value, tb_PITCH_PWM_MAX.Value);
              break;
            case 41: //  forces[MEM_PITCH]
              SetData("val_FORCE_PITCH", entry.Value);
              //SetMinMaxLineChart(entry.Value, val_FORCE_PITCH, ref chart_FORCE_PITCH, tb_PITCH_FORCE_MAX.Value * (-1), tb_PITCH_FORCE_MAX.Value);
              break;
          }
        }


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error on process ReadAllValues");
      }

    }

    /// <summary>
    /// store received parameters into list
    /// </summary>
    /// <param name="data"></param>
    /// <param name="startIndex"></param>
    private void ReadAllParams(List<DataEntry> data, int startIndex)
    {
      try
      {


        if (data == null || data.Count == 0)
          return;

        foreach (DataEntry entry in data)
        {
          switch (Convert.ToInt32(entry.Number) - startIndex)
          {
            case 0:
              SetData("tb_PITCH_FORCE_MAX", entry.GetValue());
              break;
            case 1:
              SetData("tb_PITCH_PWM_MIN", entry.GetValue());
              break;
            case 2:
              SetData("tb_PITCH_PWM_MAX", entry.GetValue());
              break;
            case 3:
              SetData("tb_ROLL_FORCE_MAX", entry.GetValue());
              break;
            case 4:
              SetData("tb_ROLL_PWM_MIN", entry.GetValue());
              break;
            case 5:
              SetData("tb_ROLL_PWM_MAX", entry.GetValue());
              break;

            case 6:
              SetData("tb_ROLL_TOTAL_GAIN", entry.GetValue());
              break;
            case 7:
              SetData("tb_ROLL_CONSTANT_GAIN", entry.GetValue());
              break;
            case 8:
              SetData("tb_ROLL_RAMP_GAIN", entry.GetValue());
              break;
            case 9:
              SetData("tb_ROLL_SQUARE_GAIN", entry.GetValue());
              break;
            case 10:
              SetData("tb_ROLL_SIN_GAIN", entry.GetValue());
              break;
            case 11:
              SetData("tb_ROLL_TRIANGLE_GAIN", entry.GetValue());
              break;
            case 12:
              SetData("tb_ROLL_SAWTOOT_DOWN_GAIN", entry.GetValue());
              break;
            case 13:
              SetData("tb_ROLL_SAWTOOTH_UP_GAIN", entry.GetValue());
              break;
            case 14:
              SetData("tb_ROLL_SPRING_GAIN", entry.GetValue());
              break;
            case 15:
              SetData("tb_ROLL_DAMPER_GAIN", entry.GetValue());
              break;
            case 16:
              SetData("tb_ROLL_INERTIA_GAIN", entry.GetValue());
              break;
            case 17:
              SetData("tb_ROLL_FRICTION_GAIN", entry.GetValue());
              break;

            case 18:
              SetData("tb_ROLL_FRICTION_MAX_POSITION_CHANGE", entry.GetValue());
              break;
            case 19:
              SetData("tb_ROLL_INERTIA_MAX_ACCELERATION", entry.GetValue());
              break;
            case 20:
              SetData("tb_ROLL_DAMPER_MAX_VELOCITY", entry.GetValue());
              break;

            case 21:
              SetData("tb_PITCH_TOTAL_GAIN", entry.GetValue());
              break;
            case 22:
              SetData("tb_PITCH_CONSTANT_GAIN", entry.GetValue());
              break;
            case 23:
              SetData("tb_PITCH_RAMP_GAIN", entry.GetValue());
              break;
            case 24:
              SetData("tb_PITCH_SQUARE_GAIN", entry.GetValue());
              break;
            case 25:
              SetData("tb_PITCH_SIN_GAIN", entry.GetValue());
              break;
            case 26:
              SetData("tb_PITCH_TRIANGLE_GAIN", entry.GetValue());
              break;
            case 27:
              SetData("tb_PITCH_SAWTOOT_DOWN_GAIN", entry.GetValue());
              break;
            case 28:
              SetData("tb_PITCH_SAWTOOTH_UP_GAIN", entry.GetValue());
              break;
            case 29:
              SetData("tb_PITCH_SPRING_GAIN", entry.GetValue());
              break;
            case 30:
              SetData("tb_PITCH_DAMPER_GAIN", entry.GetValue());
              break;
            case 31:
              SetData("tb_PITCH_INERTIA_GAIN", entry.GetValue());
              break;
            case 32:
              SetData("tb_PITCH_FRICTION_GAIN", entry.GetValue());
              break;
            case 33:
              SetData("tb_PITCH_FRICTION_MAX_POSITION_CHANGE", entry.GetValue());
              break;
            case 34:
              SetData("tb_PITCH_INERTIA_MAX_ACCELERATION", entry.GetValue());
              break;
            case 35:
              SetData("tb_PITCH_DAMPER_MAX_VELOCITY", entry.GetValue());
              break;
          }
        }


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Error on process SERIAL_CMD_ALL_PARAMS");
      }
    } //ReadAllParams

    /// <summary>
    /// Update Degub controls depending on list data
    /// </summary>
    private void UpdateDebugControls()
    {
      SetYokeCheckbox(ref cb_yoke_0, GetData("cb_yoke_0"));
      SetYokeCheckbox(ref cb_yoke_1, GetData("cb_yoke_1"));
      SetYokeCheckbox(ref cb_yoke_2, GetData("cb_yoke_2"));
      SetYokeCheckbox(ref cb_yoke_3, GetData("cb_yoke_3"));
      SetYokeCheckbox(ref cb_yoke_4, GetData("cb_yoke_4"));
      SetYokeCheckbox(ref cb_yoke_5, GetData("cb_yoke_5"));
      SetYokeCheckbox(ref cb_yoke_6, GetData("cb_yoke_6"));
      SetYokeCheckbox(ref cb_yoke_7, GetData("cb_yoke_7"));
      SetYokeCheckbox(ref cb_yoke_8, GetData("cb_yoke_8"));
      SetYokeCheckbox(ref cb_yoke_9, GetData("cb_yoke_9"));
      SetYokeCheckbox(ref cb_yoke_10, GetData("cb_yoke_10"));
      SetYokeCheckbox(ref cb_yoke_11, GetData("cb_yoke_11"));
      SetYokeCheckbox(ref cb_yoke_12, GetData("cb_yoke_12"));
      SetYokeCheckbox(ref cb_yoke_13, GetData("cb_yoke_13"));
      SetYokeCheckbox(ref cb_yoke_14, GetData("cb_yoke_14"));
      SetYokeCheckbox(ref cb_yoke_15, GetData("cb_yoke_15"));

      if (GetData("tb_sensor_down") == 0)
      {
        tb_sensor_down_black.Visible = true;
        tb_sensor_down_green.Visible = false;
      }
      else
      {
        tb_sensor_down_black.Visible = false;
        tb_sensor_down_green.Visible = true;
      }

      if (GetData("tb_sensor_up") == 0)
      {
        tb_sensor_up_black.Visible = true;
        tb_sensor_up_green.Visible = false;
      }
      else
      {
        tb_sensor_up_black.Visible = false;
        tb_sensor_up_green.Visible = true;
      }

      if (GetData("tb_sensor_left") == 0)
      {
        tb_sensor_left_black.Visible = true;
        tb_sensor_left_green.Visible = false;
      }
      else
      {
        tb_sensor_left_black.Visible = false;
        tb_sensor_left_green.Visible = true;
      }

      if (GetData("tb_sensor_right") == 0)
      {
        tb_sensor_right_black.Visible = true;
        tb_sensor_right_green.Visible = false;
      }
      else
      {
        tb_sensor_right_black.Visible = false;
        tb_sensor_right_green.Visible = true;
      }

      if (GetData("tb_button_calibration") == 0)
      {
        tb_button_calibration_black.Visible = true;
        tb_button_calibration_green.Visible = false;
      }
      else
      {
        tb_button_calibration_black.Visible = false;
        tb_button_calibration_green.Visible = true;
      }

      SetMinMaxLineChart(GetData("val_COUNTER_ROLL"), val_COUNTER_ROLL, ref chart_COUNTER_ROLL, GetData("iCalibratedRollMin"), GetData("iCalibratedRollMax"));
      SetMinMaxLineChart(GetData("val_SPEED_ROLL"), val_SPEED_ROLL, ref chart_SPEED_ROLL, GetData("tb_ROLL_PWM_MIN"), GetData("tb_ROLL_PWM_MAX"));
      SetMinMaxLineChart(GetData("val_FORCE_ROLL"), val_FORCE_ROLL, ref chart_FORCE_ROLL, GetData("tb_ROLL_FORCE_MAX") * (-1), GetData("tb_ROLL_FORCE_MAX"));

      SetMinMaxLineChart(GetData("val_COUNTER_PITCH"), val_COUNTER_PITCH, ref chart_COUNTER_PITCH, GetData("iCalibratedPitchMin"), GetData("iCalibratedPitchMax"));
      SetMinMaxLineChart(GetData("val_SPEED_PITCH"), val_SPEED_PITCH, ref chart_SPEED_PITCH, GetData("tb_PITCH_PWM_MIN"), GetData("tb_PITCH_PWM_MAX"));
      SetMinMaxLineChart(GetData("val_FORCE_PITCH"), val_FORCE_PITCH, ref chart_FORCE_PITCH, GetData("tb_PITCH_FORCE_MAX") * (-1), GetData("tb_PITCH_FORCE_MAX"));


    } //UpdateDebugControls

    /// <summary>
    /// check or uncheck a checkbox depending on value
    /// </summary>
    /// <param name="myCheckbox"></param>
    /// <param name="myValue"></param>
    private void SetYokeCheckbox(ref CheckBox myCheckbox, float myValue)
    {
      if (myValue == 0)
        myCheckbox.Checked = false;
      else
        myCheckbox.Checked = true;
    } //SetYokeCheckbox

    /// <summary>
    /// Update trackbars depending on list data
    /// </summary>
    private void UpdateParamControls()
    {
      tb_PITCH_FORCE_MAX.Value = (int)GetData("tb_PITCH_FORCE_MAX");
      tb_PITCH_PWM_MIN.Value = (int)GetData("tb_PITCH_PWM_MIN");
      tb_PITCH_PWM_MAX.Value = (int)GetData("tb_PITCH_PWM_MAX");
      tb_ROLL_FORCE_MAX.Value = (int)GetData("tb_ROLL_FORCE_MAX");
      tb_ROLL_PWM_MIN.Value = (int)GetData("tb_ROLL_PWM_MIN");
      tb_ROLL_PWM_MAX.Value = (int)GetData("tb_ROLL_PWM_MAX");
      tb_ROLL_TOTAL_GAIN.Value = (int)GetData("tb_ROLL_TOTAL_GAIN");
      tb_ROLL_CONSTANT_GAIN.Value = (int)GetData("tb_ROLL_CONSTANT_GAIN");
      tb_ROLL_RAMP_GAIN.Value = (int)GetData("tb_ROLL_RAMP_GAIN");
      tb_ROLL_SQUARE_GAIN.Value = (int)GetData("tb_ROLL_SQUARE_GAIN");
      tb_ROLL_SIN_GAIN.Value = (int)GetData("tb_ROLL_SIN_GAIN");
      tb_ROLL_TRIANGLE_GAIN.Value = (int)GetData("tb_ROLL_TRIANGLE_GAIN");
      tb_ROLL_SAWTOOT_DOWN_GAIN.Value = (int)GetData("tb_ROLL_SAWTOOT_DOWN_GAIN");
      tb_ROLL_SAWTOOTH_UP_GAIN.Value = (int)GetData("tb_ROLL_SAWTOOTH_UP_GAIN");
      tb_ROLL_SPRING_GAIN.Value = (int)GetData("tb_ROLL_SPRING_GAIN");
      tb_ROLL_DAMPER_GAIN.Value = (int)GetData("tb_ROLL_DAMPER_GAIN");
      tb_ROLL_INERTIA_GAIN.Value = (int)GetData("tb_ROLL_INERTIA_GAIN");
      tb_ROLL_FRICTION_GAIN.Value = (int)GetData("tb_ROLL_FRICTION_GAIN");
      tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Value = (int)GetData("tb_ROLL_FRICTION_MAX_POSITION_CHANGE");
      tb_ROLL_INERTIA_MAX_ACCELERATION.Value = (int)GetData("tb_ROLL_INERTIA_MAX_ACCELERATION");
      tb_ROLL_DAMPER_MAX_VELOCITY.Value = (int)GetData("tb_ROLL_DAMPER_MAX_VELOCITY");
      tb_PITCH_TOTAL_GAIN.Value = (int)GetData("tb_PITCH_TOTAL_GAIN");
      tb_PITCH_CONSTANT_GAIN.Value = (int)GetData("tb_PITCH_CONSTANT_GAIN");
      tb_PITCH_RAMP_GAIN.Value = (int)GetData("tb_PITCH_RAMP_GAIN");
      tb_PITCH_SQUARE_GAIN.Value = (int)GetData("tb_PITCH_SQUARE_GAIN");
      tb_PITCH_SIN_GAIN.Value = (int)GetData("tb_PITCH_SIN_GAIN");
      tb_PITCH_TRIANGLE_GAIN.Value = (int)GetData("tb_PITCH_TRIANGLE_GAIN");
      tb_PITCH_SAWTOOT_DOWN_GAIN.Value = (int)GetData("tb_PITCH_SAWTOOT_DOWN_GAIN");
      tb_PITCH_SAWTOOTH_UP_GAIN.Value = (int)GetData("tb_PITCH_SAWTOOTH_UP_GAIN");
      tb_PITCH_SPRING_GAIN.Value = (int)GetData("tb_PITCH_SPRING_GAIN");
      tb_PITCH_DAMPER_GAIN.Value = (int)GetData("tb_PITCH_DAMPER_GAIN");
      tb_PITCH_INERTIA_GAIN.Value = (int)GetData("tb_PITCH_INERTIA_GAIN");
      tb_PITCH_FRICTION_GAIN.Value = (int)GetData("tb_PITCH_FRICTION_GAIN");
      tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Value = (int)GetData("tb_PITCH_FRICTION_MAX_POSITION_CHANGE");
      tb_PITCH_INERTIA_MAX_ACCELERATION.Value = (int)GetData("tb_PITCH_INERTIA_MAX_ACCELERATION");
      tb_PITCH_DAMPER_MAX_VELOCITY.Value = (int)GetData("tb_PITCH_DAMPER_MAX_VELOCITY");
    } //UpdateParamControls

    /// <summary>
    /// gets a value from the List by name
    /// </summary>
    /// <param name="myName"></param>
    /// <returns></returns>
    private float GetData(string myName)
    {
      if (string.IsNullOrEmpty(myName))
        return 0.0f;

      if (dataList == null)
        return 0.0f;

      if (dataList.ContainsKey(myName))
      {
        return dataList[myName];
      }
      else
      {
        return 0.0f;
      }
    } //GetData

    /// <summary>
    /// Sets a value on a list by name, string given
    /// </summary>
    /// <param name="myName"></param>
    /// <param name="myValue"></param>
    private void SetData(string myName, string myValue)
    {
      float tmp = 0.0f;

      if (string.IsNullOrEmpty(myValue))
        return;

      if (string.IsNullOrEmpty(myName))
        return;

      if (dataList == null)
        return;

      try
      {
        tmp = float.Parse(myValue);
      }
      catch
      {
        tmp = 0.0f;
      }

      dataList[myName] = tmp;
    } //SetData

    /// <summary>
    /// Sets a value on a list by name, int given
    /// </summary>
    /// <param name="myName"></param>
    /// <param name="myValue"></param>
    private void SetData(string myName, int myValue)
    {
      if (string.IsNullOrEmpty(myName))
        return;

      if (dataList == null)
        return;

      dataList[myName] = myValue;
    } //SetData

    /// <summary>
    /// Set chart values for debug
    /// </summary>
    /// <param name="myValue"></param>
    /// <param name="dataList"></param>
    /// <param name="myChart"></param>
    /// <param name="min"></param>
    /// <param name="max"></param>
    private void SetMinMaxLineChart(float myValue, List<float> dataList, ref Chart myChart, float min, float max)
    {

      if (dataList == null)
        return;

      if (dataList.Count >= 60)
        dataList.RemoveAt(0);

      dataList.Add(myValue);
      myChart.ChartAreas[0].AxisY.Title = "Min: " + min.ToString() + " - Max: " + max.ToString() + " - Value: " + myValue.ToString();
      myChart.Series[0].Points.Clear();
      myChart.Series[1].Points.Clear();
      myChart.Series[2].Points.Clear();
      int x = 1;
      foreach (float v in dataList)
      {
        myChart.Series[0].Points.AddXY(x, v);
        myChart.Series[1].Points.AddXY(x, max);
        myChart.Series[2].Points.AddXY(x, min);
        x++;
      }
    } //SetLineChart

  } // class
} // namespace
