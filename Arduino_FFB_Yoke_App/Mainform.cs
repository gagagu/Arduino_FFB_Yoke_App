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

namespace Arduino_FFB_Yoke_App
{
    public partial class Mainform : Form
    {

        private SerialPort SerPort  = new SerialPort();
        private string ReceivedData=""; //received data
        private Dictionary<string, string> nameList = new Dictionary<string, string>();
        private Dictionary<string, string> myData = new Dictionary<string, string>();

        private List<float> val_POTI_ROLL = new List<float>();
        private List<float> val_POS_ROLL = new List<float>();
        private List<float> val_SPEED_ROLL = new List<float>();
        private List<float> val_FORCE_ROLL = new List<float>();

        private List<float> val_POTI_PITCH = new List<float>();
        private List<float> val_POS_PITCH = new List<float>();
        private List<float> val_SPEED_PITCH = new List<float>();
        private List<float> val_FORCE_PITCH = new List<float>();

        delegate void SetTextCallback(string text);

        public Mainform()
        {
            InitializeComponent();
        }
        private void Mainform_Load(object sender, EventArgs e)
        {
            SetNameList();
            FetchAvailablePorts();
            //firstSeries();
        }

        private void SetNameList() {
            nameList["0"] = "";
            nameList["1"] = "pos[MEM_ROLL]";
            nameList["2"] = "pos[MEM_PITCH]";
            nameList["3"] = "positionChangeX";
            nameList["4"] = "positionChangeY";
            nameList["5"] = "velX";
            nameList["6"] = "velY";
            nameList["7"] = "accelX";
            nameList["8"] = "accelY";
            nameList["9"] = "forces[MEM_ROLL]";
            nameList["10"] = "forces[MEM_PITCH]";
            nameList["11"] = "poti_roll_min";
            nameList["12"] = "poti_roll_max";
            nameList["13"] = "analogRead(POTI_ROLL)";
            nameList["14"] = "pos[MEM_ROLL]";
            nameList["15"] = "poti_pitch_min";
            nameList["16"] = "poti_pitch_max";
            nameList["17"] = "analogRead(POTI_PITCH)";
            nameList["18"] = "pos[MEM_PITCH]";
            nameList["19"] = "roll_speed";
            nameList["20"] = "pitch_speed";
            nameList["21"] = "ADJ_ENDSWITCH_PITCH_DOWN";
            nameList["22"] = "ADJ_ENDSWITCH_PITCH_UP";
            nameList["23"] = "ADJ_ENDSWITCH_ROLL_LEFT";
            nameList["24"] = "ADJ_ENDSWITCH_ROLL_RIGHT";
            nameList["25"] = "ADJ_BUTTON_CALIBRATION";
            nameList["26"] = "ADJ_POTI_PITCH_FORCE_MAX";
            nameList["27"] = "ADJ_POTI_PITCH_PWM_MAX";
            nameList["28"] = "ADJ_POTI_PITCH_PWM_MIN";
            nameList["29"] = "ADJ_POTI_ROLL_FORCE_MAX";
            nameList["30"] = "ADJ_POTI_ROLL_PWM_MAX";
            nameList["31"] = "ADJ_POTI_ROLL_PWM_MIN";
            nameList["32"] = "hat_right";
            nameList["33"] = "hat_down";
            nameList["34"] = "hat_up";
            nameList["35"] = "hat_left";

            nameList["36"] = "button_0";
            nameList["37"] = "button_1";
            nameList["38"] = "button_2";
            nameList["39"] = "button_3";
            nameList["40"] = "button_4";
            nameList["41"] = "button_5";
            nameList["42"] = "button_6";
            nameList["43"] = "button_7";
            nameList["44"] = "button_8";
            nameList["45"] = "button_9";
            nameList["46"] = "button_10";
            nameList["47"] = "button_11";
            nameList["48"] = "button_12";
            nameList["49"] = "poti_roll_middle";
            nameList["50"] = "poti_roll_deadzone";
            nameList["51"] = "poti_pitch_middle";
            nameList["52"] = "poti_pitch_deadzone";
            nameList["53"] = "";
            nameList["54"] = "";
            nameList["55"] = "";
            nameList["56"] = "";
            nameList["57"] = "";
            nameList["58"] = "";
            nameList["59"] = "";

        }

        void FetchAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();//Put the name of the available USB ports into the ports string array
            AvailablePortsBox.Items.AddRange(ports); //Add the string into the dropdown list we made
            if (AvailablePortsBox.Items.Count > 0)
            {
                AvailablePortsBox.SelectedIndex = 0;
            }
        }

        private void ConnectToPort_Click(object sender, EventArgs e)
        {
            System.ComponentModel.IContainer components =new System.ComponentModel.Container();
            //This is some predefined thing that you can get from Google
            SerPort = new SerialPort();
            SerPort.BaudRate = 115200;
            SerPort.PortName = AvailablePortsBox.Text;
            SerPort.Parity = Parity.None;
            SerPort.DataBits = 8;
            SerPort.StopBits = StopBits.One;
            SerPort.RtsEnable = true;
            SerPort.DtrEnable = true;

            try
            {
                ReceivedDataBox.Text="Connect to Port:" + AvailablePortsBox.Text + "\r\n";
                SerPort.Open(); //We open the port
                Thread.Sleep(1000); //We wait a sec
                ReceivedDataBox.Text += "Connected. Read data" + "\r\n";
                while (true)
                {
                    ReceivedData = SerPort.ReadLine();
                    ProcessingData();
                }
            }
            catch (Exception ex)
            {
                ReceivedDataBox.Text += "Error:" +ex.Message + "\r\n";
            }
        }


        private void ProcessingData()
        {
            try
            {
                string data = ReceivedData.ToString();
                string[] rows = data.Split(' ');
                foreach (string row in rows)
                {
                    string[] entry = row.Split(':');
                    if (entry != null && entry.Length == 2)
                    {
                        string name = nameList[entry[0]];
                        if (name != null && name.Length > 0)
                        {
                            myData[name] = entry[1];
                        }
                    }
                }


                //ReceivedDataBox.Text = "";
                //foreach (KeyValuePair<string, string> element in myData)
                //{
                //    ReceivedDataBox.Text += element.Key.ToString() + ":" + element.Value + "\r\n";
                //}
                //Application.DoEvents();
                UpdateView();
            }
            catch (Exception ex) {
                ReceivedDataBox.Text += "Error:" + ex.Message + "\r\n";
            }
        }

        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if(SerPort!=null && SerPort.IsOpen)
                    SerPort.Close(); //close the port on from closing
            }
            catch
            {
            }
        }
        private void UpdateView()
        {
            try
            {

                //buttons
                for (int x = 0; x < 12; x++)
                {
                    SetButtonColor("button" + x, "button_" + x);
                }

                // hat
                SetButtonColor("button_hat_right", "hat_right");
                SetButtonColor("button_hat_left", "hat_left");
                SetButtonColor("button_hat_up", "hat_up");
                SetButtonColor("button_hat_down", "hat_down");

                // end switch
                SetButtonColor("button_ADJ_ENDSWITCH_PITCH_DOWN", "ADJ_ENDSWITCH_PITCH_DOWN");
                SetButtonColor("button_ADJ_ENDSWITCH_PITCH_UP", "ADJ_ENDSWITCH_PITCH_UP");
                SetButtonColor("button_ADJ_ENDSWITCH_ROLL_LEFT", "ADJ_ENDSWITCH_ROLL_LEFT");
                SetButtonColor("button_ADJ_ENDSWITCH_ROLL_RIGHT", "ADJ_ENDSWITCH_ROLL_RIGHT");
                // Calib Button
                SetButtonColor("button_ADJ_BUTTON_CALIBRATION", "ADJ_BUTTON_CALIBRATION");

                if (myData.ContainsKey("ADJ_POTI_PITCH_FORCE_MAX"))
                    txt_ADJ_POTI_PITCH_FORCE_MAX.Text = myData["ADJ_POTI_PITCH_FORCE_MAX"];

                if (myData.ContainsKey("ADJ_POTI_PITCH_PWM_MAX"))
                    txt_ADJ_POTI_PITCH_PWM_MAX.Text = myData["ADJ_POTI_PITCH_PWM_MAX"];

                if (myData.ContainsKey("ADJ_POTI_PITCH_PWM_MIN"))
                    txt_ADJ_POTI_PITCH_PWM_MIN.Text = myData["ADJ_POTI_PITCH_PWM_MIN"];

                if (myData.ContainsKey("ADJ_POTI_ROLL_FORCE_MAX"))
                    txt_ADJ_POTI_ROLL_FORCE_MAX.Text = myData["ADJ_POTI_ROLL_FORCE_MAX"];

                if (myData.ContainsKey("ADJ_POTI_ROLL_PWM_MAX"))
                    txt_ADJ_POTI_ROLL_PWM_MAX.Text = myData["ADJ_POTI_ROLL_PWM_MAX"];

                if (myData.ContainsKey("ADJ_POTI_ROLL_PWM_MIN"))
                    txt_ADJ_POTI_ROLL_PWM_MIN.Text = myData["ADJ_POTI_ROLL_PWM_MIN"];

                // Roll
                if (myData.ContainsKey("poti_roll_min"))
                    txt_poti_roll_min.Text = myData["poti_roll_min"];

                if (myData.ContainsKey("poti_roll_max"))
                    txt_poti_roll_max.Text = myData["poti_roll_max"];

                if (myData.ContainsKey("poti_roll_middle"))
                    txt_poti_roll_middle.Text = myData["poti_roll_middle"];

                if (myData.ContainsKey("poti_roll_deadzone"))
                    txt_poti_roll_deadzone.Text = myData["poti_roll_deadzone"];

                SetLineChart("analogRead(POTI_ROLL)", val_POTI_ROLL,ref chart_POTI_ROLL);
                SetLineChart("pos[MEM_ROLL]", val_POS_ROLL, ref chart_POS_ROLL);
                SetLineChart("roll_speed", val_SPEED_ROLL, ref chart_SPEED_ROLL);
                SetLineChart("forces[MEM_ROLL]", val_FORCE_ROLL, ref chart_FORCE_ROLL);

                chart_POS_ROLL.ChartAreas[0].AxisY.Crossing = 0;
                chart_FORCE_ROLL.ChartAreas[0].AxisY.Crossing = 0;

                // Pitch
                if (myData.ContainsKey("poti_pitch_min"))
                    txt_poti_pitch_min.Text = myData["poti_pitch_min"];

                if (myData.ContainsKey("poti_pitch_max"))
                    txt_poti_pitch_max.Text = myData["poti_pitch_max"];

                if (myData.ContainsKey("poti_pitch_middle"))
                    txt_poti_pitch_middle.Text = myData["poti_pitch_middle"];

                if (myData.ContainsKey("poti_pitch_deadzone"))
                    txt_poti_pitch_deadzone.Text = myData["poti_pitch_deadzone"];

                SetLineChart("analogRead(POTI_PITCH)", val_POTI_PITCH, ref chart_POTI_PITCH);
                SetLineChart("pos[MEM_PITCH]", val_POS_PITCH, ref chart_POS_PITCH);
                SetLineChart("pitch_speed", val_SPEED_PITCH, ref chart_SPEED_PITCH);
                SetLineChart("forces[MEM_PITCH]", val_FORCE_PITCH, ref chart_FORCE_PITCH);

                chart_POS_PITCH.ChartAreas[0].AxisY.Crossing = 0;
                chart_FORCE_PITCH.ChartAreas[0].AxisY.Crossing = 0;
            }
            catch
            {
            }
            Application.DoEvents();
        }

        private void SetLineChart(string keyName, List<float> dataList,ref Chart myChart)
        {
            if (myData.ContainsKey(keyName))
            {
                if (dataList == null)
                    return;

                if (dataList.Count >= 60)
                    dataList.RemoveAt(0);

                float tmp = float.Parse(myData[keyName]);
                dataList.Add(tmp);
                myChart.ChartAreas[0].AxisY.Title = "Value: " + tmp.ToString();
                myChart.Series[0].Points.Clear();
                int x = 1;
                foreach (float v in dataList)
                {
                    myChart.Series[0].Points.AddXY(x, v);
                    x++;
                }
            }
        }

        private void SetButtonColor(string controlName, string keyName) {
            if (this.tabButtons.Controls.ContainsKey(controlName))
            {
                if (myData.ContainsKey(keyName) && myData[keyName] == "1")
                    this.tabButtons.Controls[controlName].BackColor = Color.Green;
                else
                    this.tabButtons.Controls[controlName].BackColor = Color.Transparent;
            }
        }


        private void firstSeries()
        {
            // chartArea
           // ChartArea chartArea = new ChartArea();
           // chartArea.Name = "First Area";
           // chart_Roll.ChartAreas.Add(chartArea);
            //chartArea.BackColor = Color.Azure;
            //chartArea.BackGradientStyle = GradientStyle.HorizontalCenter;
            //chartArea.BackHatchStyle = ChartHatchStyle.LargeGrid;
            //chartArea.BorderDashStyle = ChartDashStyle.Solid;
            //chartArea.BorderWidth = 1;
            //chartArea.BorderColor = Color.Red;
            //chartArea.ShadowColor = Color.Purple;
            //chartArea.ShadowOffset = 0;
            //chart_Roll.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;//x axis
            //chart_Roll.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;//y axis

            //Cursor：only apply the top area
            //chartArea.CursorX.IsUserEnabled = true;
            //chartArea.CursorX.AxisType = AxisType.Primary;//act on primary x axis
            //chartArea.CursorX.Interval = 1;
            //chartArea.CursorX.LineWidth = 1;
            //chartArea.CursorX.LineDashStyle = ChartDashStyle.Dash;
            //chartArea.CursorX.IsUserSelectionEnabled = true;
            //chartArea.CursorX.SelectionColor = Color.Yellow;
            //chartArea.CursorX.AutoScroll = true;

            //chartArea.CursorY.IsUserEnabled = true;
            //chartArea.CursorY.AxisType = AxisType.Primary;//act on primary y axis
            //chartArea.CursorY.Interval = 1;
            //chartArea.CursorY.LineWidth = 1;
            //chartArea.CursorY.LineDashStyle = ChartDashStyle.Dash;
            //chartArea.CursorY.IsUserSelectionEnabled = true;
            //chartArea.CursorY.SelectionColor = Color.Yellow;
            //chartArea.CursorY.AutoScroll = true;

            // Axis
            //chartArea.AxisY.Minimum = -32000;//Y axis Minimum value
            //chartArea.AxisY.Title = @"Test";
            //chartArea.AxisY.Maximum = 32000;//Y axis Maximum value

            //chartArea.AxisX.Minimum = 0d; //X axis Minimum value
            //chartArea.AxisX.Maximum = 60d;
            //chartArea.AxisX.IsLabelAutoFit = true;
            ////chartArea.AxisX.LabelAutoFitMaxFontSize = 12;
            //chartArea.AxisX.LabelAutoFitMinFontSize = 5;
            //chartArea.AxisX.LabelStyle.Angle = -20;
            //chartArea.AxisX.LabelStyle.IsEndLabelVisible = true;//show the last label
            //chartArea.AxisX.Interval = 1;
            //chartArea.AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            //chartArea.AxisX.IntervalType = DateTimeIntervalType.NotSet;
            //chartArea.AxisX.Title = @"Time";
            //chartArea.AxisX.TextOrientation = TextOrientation.Rotated90;
            //chartArea.AxisX.LineWidth = 2;
            //chartArea.AxisX.LineColor = Color.DarkOrchid;
            //chartArea.AxisX.Enabled = AxisEnabled.True;
            //chartArea.AxisX.ScaleView.MinSizeType = DateTimeIntervalType.Months;
            //chartArea.AxisX.ScrollBar = new AxisScrollBar();
            

            ////Series
            //Series series1 = new Series();
            //series1.ChartArea = "First Area";
            //chart_Roll.Series.Add(series1);
            ////Series style
            //series1.Name = @"series：Test One";
            //series1.ChartType = SeriesChartType.Line;  // type
            //series1.BorderWidth = 2;
            //series1.Color = Color.Green;
            //series1.XValueType = ChartValueType.Int32;//x axis type
            //series1.YValueType = ChartValueType.Int32;//y axis type
            //// series.YValuesPerPoint = 6;

            ////Marker
            //series1.MarkerStyle = MarkerStyle.Star4;
            //series1.MarkerSize = 10;
            //series1.MarkerStep = 1;
            //series1.MarkerColor = Color.Red;
            //series1.ToolTip = @"ToolTip";

            ////Label
            //series1.IsValueShownAsLabel = true;
            //series1.SmartLabelStyle.Enabled = false;
            //series1.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;
            //series1.LabelForeColor = Color.Gray;
            //series1.LabelToolTip = @"LabelToolTip";

            ////Empty Point Style 
            //DataPointCustomProperties p = new DataPointCustomProperties();
            //p.Color = Color.Green;
            //series1.EmptyPointStyle = p;

            ////Legend
            //series1.LegendText = "LegendText：Test One";
            //series1.LegendToolTip = @"LegendToolTip";

            //float[] values = { 0, 70, 90, 20, 70, 220, 30, 60, 30, 81, 10, 39 };
            ////series1.Points.Clear();
            //int x = 1;
            //foreach (float v in val_POTI_ROLL)
            //{
            //    series1.Points.AddXY(x, v);
            //    x++;
            //}


          
        }
    }// class
}// namespace