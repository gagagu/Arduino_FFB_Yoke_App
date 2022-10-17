using System.Windows.Forms;

namespace Arduino_FFB_Yoke_App
{
    partial class Mainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ReceivedDataBox = new System.Windows.Forms.TextBox();
            this.AvailablePortsBox = new System.Windows.Forms.ComboBox();
            this.ConnectToPort = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabButtons = new System.Windows.Forms.TabPage();
            this.button_ADJ_BUTTON_CALIBRATION = new System.Windows.Forms.Button();
            this.button_ADJ_ENDSWITCH_ROLL_LEFT = new System.Windows.Forms.Button();
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT = new System.Windows.Forms.Button();
            this.button_ADJ_ENDSWITCH_PITCH_DOWN = new System.Windows.Forms.Button();
            this.button_ADJ_ENDSWITCH_PITCH_UP = new System.Windows.Forms.Button();
            this.button_hat_left = new System.Windows.Forms.Button();
            this.button_hat_right = new System.Windows.Forms.Button();
            this.button_hat_down = new System.Windows.Forms.Button();
            this.button_hat_up = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabRoll = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_poti_roll_deadzone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_poti_roll_middle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ADJ_POTI_ROLL_PWM_MIN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ADJ_POTI_ROLL_PWM_MAX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ADJ_POTI_ROLL_FORCE_MAX = new System.Windows.Forms.TextBox();
            this.chart_FORCE_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_SPEED_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_POS_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_poti_roll_max = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_poti_roll_min = new System.Windows.Forms.TextBox();
            this.chart_POTI_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPitch = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_poti_pitch_deadzone = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_poti_pitch_middle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_poti_pitch_max = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_poti_pitch_min = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ADJ_POTI_PITCH_PWM_MIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ADJ_POTI_PITCH_PWM_MAX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ADJ_POTI_PITCH_FORCE_MAX = new System.Windows.Forms.TextBox();
            this.chart_FORCE_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_SPEED_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_POS_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_POTI_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabButtons.SuspendLayout();
            this.tabRoll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_ROLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_ROLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POS_ROLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POTI_ROLL)).BeginInit();
            this.tabPitch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_PITCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_PITCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POS_PITCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POTI_PITCH)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceivedDataBox
            // 
            this.ReceivedDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReceivedDataBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReceivedDataBox.Location = new System.Drawing.Point(41, 560);
            this.ReceivedDataBox.Multiline = true;
            this.ReceivedDataBox.Name = "ReceivedDataBox";
            this.ReceivedDataBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ReceivedDataBox.Size = new System.Drawing.Size(1382, 76);
            this.ReceivedDataBox.TabIndex = 0;
            // 
            // AvailablePortsBox
            // 
            this.AvailablePortsBox.FormattingEnabled = true;
            this.AvailablePortsBox.Location = new System.Drawing.Point(41, 21);
            this.AvailablePortsBox.Name = "AvailablePortsBox";
            this.AvailablePortsBox.Size = new System.Drawing.Size(361, 21);
            this.AvailablePortsBox.TabIndex = 1;
            // 
            // ConnectToPort
            // 
            this.ConnectToPort.Location = new System.Drawing.Point(435, 21);
            this.ConnectToPort.Name = "ConnectToPort";
            this.ConnectToPort.Size = new System.Drawing.Size(64, 20);
            this.ConnectToPort.TabIndex = 2;
            this.ConnectToPort.Text = "Connect";
            this.ConnectToPort.UseVisualStyleBackColor = true;
            this.ConnectToPort.Click += new System.EventHandler(this.ConnectToPort_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabButtons);
            this.tabControl1.Controls.Add(this.tabRoll);
            this.tabControl1.Controls.Add(this.tabPitch);
            this.tabControl1.Location = new System.Drawing.Point(41, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1382, 508);
            this.tabControl1.TabIndex = 3;
            // 
            // tabButtons
            // 
            this.tabButtons.AutoScroll = true;
            this.tabButtons.BackColor = System.Drawing.Color.Gray;
            this.tabButtons.Controls.Add(this.button_ADJ_BUTTON_CALIBRATION);
            this.tabButtons.Controls.Add(this.button_ADJ_ENDSWITCH_ROLL_LEFT);
            this.tabButtons.Controls.Add(this.button_ADJ_ENDSWITCH_ROLL_RIGHT);
            this.tabButtons.Controls.Add(this.button_ADJ_ENDSWITCH_PITCH_DOWN);
            this.tabButtons.Controls.Add(this.button_ADJ_ENDSWITCH_PITCH_UP);
            this.tabButtons.Controls.Add(this.button_hat_left);
            this.tabButtons.Controls.Add(this.button_hat_right);
            this.tabButtons.Controls.Add(this.button_hat_down);
            this.tabButtons.Controls.Add(this.button_hat_up);
            this.tabButtons.Controls.Add(this.button7);
            this.tabButtons.Controls.Add(this.button8);
            this.tabButtons.Controls.Add(this.button9);
            this.tabButtons.Controls.Add(this.button10);
            this.tabButtons.Controls.Add(this.button11);
            this.tabButtons.Controls.Add(this.button0);
            this.tabButtons.Controls.Add(this.button6);
            this.tabButtons.Controls.Add(this.button5);
            this.tabButtons.Controls.Add(this.button4);
            this.tabButtons.Controls.Add(this.button3);
            this.tabButtons.Controls.Add(this.button2);
            this.tabButtons.Controls.Add(this.button1);
            this.tabButtons.Location = new System.Drawing.Point(4, 22);
            this.tabButtons.Name = "tabButtons";
            this.tabButtons.Padding = new System.Windows.Forms.Padding(3);
            this.tabButtons.Size = new System.Drawing.Size(1374, 482);
            this.tabButtons.TabIndex = 0;
            this.tabButtons.Text = "Button/Poti/Switch";
            // 
            // button_ADJ_BUTTON_CALIBRATION
            // 
            this.button_ADJ_BUTTON_CALIBRATION.Enabled = false;
            this.button_ADJ_BUTTON_CALIBRATION.Location = new System.Drawing.Point(539, 327);
            this.button_ADJ_BUTTON_CALIBRATION.Name = "button_ADJ_BUTTON_CALIBRATION";
            this.button_ADJ_BUTTON_CALIBRATION.Size = new System.Drawing.Size(88, 34);
            this.button_ADJ_BUTTON_CALIBRATION.TabIndex = 20;
            this.button_ADJ_BUTTON_CALIBRATION.Text = "Calibration Button";
            this.button_ADJ_BUTTON_CALIBRATION.UseVisualStyleBackColor = true;
            // 
            // button_ADJ_ENDSWITCH_ROLL_LEFT
            // 
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.Enabled = false;
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.Location = new System.Drawing.Point(445, 218);
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.Name = "button_ADJ_ENDSWITCH_ROLL_LEFT";
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.Size = new System.Drawing.Size(88, 34);
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.TabIndex = 19;
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.Text = "end switch roll left";
            this.button_ADJ_ENDSWITCH_ROLL_LEFT.UseVisualStyleBackColor = true;
            // 
            // button_ADJ_ENDSWITCH_ROLL_RIGHT
            // 
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.Enabled = false;
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.Location = new System.Drawing.Point(633, 218);
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.Name = "button_ADJ_ENDSWITCH_ROLL_RIGHT";
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.Size = new System.Drawing.Size(88, 34);
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.TabIndex = 18;
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.Text = "end switch roll right";
            this.button_ADJ_ENDSWITCH_ROLL_RIGHT.UseVisualStyleBackColor = true;
            // 
            // button_ADJ_ENDSWITCH_PITCH_DOWN
            // 
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.Enabled = false;
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.Location = new System.Drawing.Point(539, 243);
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.Name = "button_ADJ_ENDSWITCH_PITCH_DOWN";
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.Size = new System.Drawing.Size(88, 34);
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.TabIndex = 17;
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.Text = "end switch pitch down";
            this.button_ADJ_ENDSWITCH_PITCH_DOWN.UseVisualStyleBackColor = true;
            // 
            // button_ADJ_ENDSWITCH_PITCH_UP
            // 
            this.button_ADJ_ENDSWITCH_PITCH_UP.Enabled = false;
            this.button_ADJ_ENDSWITCH_PITCH_UP.Location = new System.Drawing.Point(539, 199);
            this.button_ADJ_ENDSWITCH_PITCH_UP.Name = "button_ADJ_ENDSWITCH_PITCH_UP";
            this.button_ADJ_ENDSWITCH_PITCH_UP.Size = new System.Drawing.Size(88, 34);
            this.button_ADJ_ENDSWITCH_PITCH_UP.TabIndex = 16;
            this.button_ADJ_ENDSWITCH_PITCH_UP.Text = "end switch pitch up";
            this.button_ADJ_ENDSWITCH_PITCH_UP.UseVisualStyleBackColor = true;
            // 
            // button_hat_left
            // 
            this.button_hat_left.Enabled = false;
            this.button_hat_left.Location = new System.Drawing.Point(445, 62);
            this.button_hat_left.Name = "button_hat_left";
            this.button_hat_left.Size = new System.Drawing.Size(88, 34);
            this.button_hat_left.TabIndex = 15;
            this.button_hat_left.Text = "hat left";
            this.button_hat_left.UseVisualStyleBackColor = true;
            // 
            // button_hat_right
            // 
            this.button_hat_right.Enabled = false;
            this.button_hat_right.Location = new System.Drawing.Point(633, 62);
            this.button_hat_right.Name = "button_hat_right";
            this.button_hat_right.Size = new System.Drawing.Size(88, 34);
            this.button_hat_right.TabIndex = 14;
            this.button_hat_right.Text = "hat right";
            this.button_hat_right.UseVisualStyleBackColor = true;
            // 
            // button_hat_down
            // 
            this.button_hat_down.Enabled = false;
            this.button_hat_down.Location = new System.Drawing.Point(539, 87);
            this.button_hat_down.Name = "button_hat_down";
            this.button_hat_down.Size = new System.Drawing.Size(88, 34);
            this.button_hat_down.TabIndex = 13;
            this.button_hat_down.Text = "hat down";
            this.button_hat_down.UseVisualStyleBackColor = true;
            // 
            // button_hat_up
            // 
            this.button_hat_up.Enabled = false;
            this.button_hat_up.Location = new System.Drawing.Point(539, 43);
            this.button_hat_up.Name = "button_hat_up";
            this.button_hat_up.Size = new System.Drawing.Size(88, 34);
            this.button_hat_up.TabIndex = 12;
            this.button_hat_up.Text = "hat up";
            this.button_hat_up.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(115, 58);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(115, 98);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 34);
            this.button8.TabIndex = 10;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(115, 138);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 34);
            this.button9.TabIndex = 9;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(115, 178);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 34);
            this.button10.TabIndex = 8;
            this.button10.Text = "button10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(115, 218);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 34);
            this.button11.TabIndex = 7;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            this.button0.Enabled = false;
            this.button0.Location = new System.Drawing.Point(21, 18);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(88, 34);
            this.button0.TabIndex = 6;
            this.button0.Text = "button0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(115, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(21, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(21, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(21, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(21, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(21, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabRoll
            // 
            this.tabRoll.BackColor = System.Drawing.Color.Gray;
            this.tabRoll.Controls.Add(this.label11);
            this.tabRoll.Controls.Add(this.txt_poti_roll_deadzone);
            this.tabRoll.Controls.Add(this.label12);
            this.tabRoll.Controls.Add(this.txt_poti_roll_middle);
            this.tabRoll.Controls.Add(this.label4);
            this.tabRoll.Controls.Add(this.txt_ADJ_POTI_ROLL_PWM_MIN);
            this.tabRoll.Controls.Add(this.label5);
            this.tabRoll.Controls.Add(this.txt_ADJ_POTI_ROLL_PWM_MAX);
            this.tabRoll.Controls.Add(this.label6);
            this.tabRoll.Controls.Add(this.txt_ADJ_POTI_ROLL_FORCE_MAX);
            this.tabRoll.Controls.Add(this.chart_FORCE_ROLL);
            this.tabRoll.Controls.Add(this.chart_SPEED_ROLL);
            this.tabRoll.Controls.Add(this.chart_POS_ROLL);
            this.tabRoll.Controls.Add(this.label7);
            this.tabRoll.Controls.Add(this.txt_poti_roll_max);
            this.tabRoll.Controls.Add(this.label8);
            this.tabRoll.Controls.Add(this.txt_poti_roll_min);
            this.tabRoll.Controls.Add(this.chart_POTI_ROLL);
            this.tabRoll.Location = new System.Drawing.Point(4, 22);
            this.tabRoll.Name = "tabRoll";
            this.tabRoll.Size = new System.Drawing.Size(1374, 482);
            this.tabRoll.TabIndex = 2;
            this.tabRoll.Text = "Roll";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1118, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Poti Roll deadzone";
            // 
            // txt_poti_roll_deadzone
            // 
            this.txt_poti_roll_deadzone.Location = new System.Drawing.Point(1229, 159);
            this.txt_poti_roll_deadzone.Name = "txt_poti_roll_deadzone";
            this.txt_poti_roll_deadzone.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_roll_deadzone.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1138, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Poti Roll middle";
            // 
            // txt_poti_roll_middle
            // 
            this.txt_poti_roll_middle.Location = new System.Drawing.Point(1229, 133);
            this.txt_poti_roll_middle.Name = "txt_poti_roll_middle";
            this.txt_poti_roll_middle.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_roll_middle.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1137, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Roll PWM min.";
            // 
            // txt_ADJ_POTI_ROLL_PWM_MIN
            // 
            this.txt_ADJ_POTI_ROLL_PWM_MIN.Location = new System.Drawing.Point(1229, 237);
            this.txt_ADJ_POTI_ROLL_PWM_MIN.Name = "txt_ADJ_POTI_ROLL_PWM_MIN";
            this.txt_ADJ_POTI_ROLL_PWM_MIN.Size = new System.Drawing.Size(100, 20);
            this.txt_ADJ_POTI_ROLL_PWM_MIN.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1137, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Roll PWM max";
            // 
            // txt_ADJ_POTI_ROLL_PWM_MAX
            // 
            this.txt_ADJ_POTI_ROLL_PWM_MAX.Location = new System.Drawing.Point(1229, 211);
            this.txt_ADJ_POTI_ROLL_PWM_MAX.Name = "txt_ADJ_POTI_ROLL_PWM_MAX";
            this.txt_ADJ_POTI_ROLL_PWM_MAX.Size = new System.Drawing.Size(100, 20);
            this.txt_ADJ_POTI_ROLL_PWM_MAX.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1137, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Roll max. Force";
            // 
            // txt_ADJ_POTI_ROLL_FORCE_MAX
            // 
            this.txt_ADJ_POTI_ROLL_FORCE_MAX.Location = new System.Drawing.Point(1229, 185);
            this.txt_ADJ_POTI_ROLL_FORCE_MAX.Name = "txt_ADJ_POTI_ROLL_FORCE_MAX";
            this.txt_ADJ_POTI_ROLL_FORCE_MAX.Size = new System.Drawing.Size(100, 20);
            this.txt_ADJ_POTI_ROLL_FORCE_MAX.TabIndex = 36;
            // 
            // chart_FORCE_ROLL
            // 
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.Maximum = 60D;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisY.Maximum = 15000D;
            chartArea1.AxisY.Minimum = -15000D;
            chartArea1.AxisY.Title = "Value: 0";
            chartArea1.Name = "ChartArea1";
            this.chart_FORCE_ROLL.ChartAreas.Add(chartArea1);
            this.chart_FORCE_ROLL.Location = new System.Drawing.Point(567, 333);
            this.chart_FORCE_ROLL.Name = "chart_FORCE_ROLL";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart_FORCE_ROLL.Series.Add(series1);
            this.chart_FORCE_ROLL.Size = new System.Drawing.Size(517, 308);
            this.chart_FORCE_ROLL.TabIndex = 35;
            this.chart_FORCE_ROLL.Text = "Roll";
            title1.Name = "Title1";
            title1.Text = "Force Roll";
            this.chart_FORCE_ROLL.Titles.Add(title1);
            // 
            // chart_SPEED_ROLL
            // 
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisX.Maximum = 60D;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisY.Maximum = 255D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Value: 0";
            chartArea2.Name = "ChartArea1";
            this.chart_SPEED_ROLL.ChartAreas.Add(chartArea2);
            this.chart_SPEED_ROLL.Location = new System.Drawing.Point(20, 333);
            this.chart_SPEED_ROLL.Name = "chart_SPEED_ROLL";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart_SPEED_ROLL.Series.Add(series2);
            this.chart_SPEED_ROLL.Size = new System.Drawing.Size(517, 308);
            this.chart_SPEED_ROLL.TabIndex = 34;
            this.chart_SPEED_ROLL.Text = "Roll";
            title2.Name = "Title1";
            title2.Text = "Speed Roll (PWM)";
            this.chart_SPEED_ROLL.Titles.Add(title2);
            // 
            // chart_POS_ROLL
            // 
            chartArea3.AxisX.LabelStyle.Enabled = false;
            chartArea3.AxisX.Maximum = 60D;
            chartArea3.AxisX.Minimum = 1D;
            chartArea3.AxisY.Maximum = 32767D;
            chartArea3.AxisY.Minimum = -32768D;
            chartArea3.AxisY.Title = "Value: 0";
            chartArea3.Name = "ChartArea1";
            this.chart_POS_ROLL.ChartAreas.Add(chartArea3);
            this.chart_POS_ROLL.Location = new System.Drawing.Point(567, 19);
            this.chart_POS_ROLL.Name = "chart_POS_ROLL";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "Series1";
            this.chart_POS_ROLL.Series.Add(series3);
            this.chart_POS_ROLL.Size = new System.Drawing.Size(517, 308);
            this.chart_POS_ROLL.TabIndex = 33;
            this.chart_POS_ROLL.Text = "Roll";
            title3.Name = "Title1";
            title3.Text = "Position Roll";
            this.chart_POS_ROLL.Titles.Add(title3);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1149, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Poti Roll max";
            // 
            // txt_poti_roll_max
            // 
            this.txt_poti_roll_max.Location = new System.Drawing.Point(1229, 107);
            this.txt_poti_roll_max.Name = "txt_poti_roll_max";
            this.txt_poti_roll_max.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_roll_max.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1149, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Poti Roll min";
            // 
            // txt_poti_roll_min
            // 
            this.txt_poti_roll_min.Location = new System.Drawing.Point(1229, 81);
            this.txt_poti_roll_min.Name = "txt_poti_roll_min";
            this.txt_poti_roll_min.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_roll_min.TabIndex = 29;
            // 
            // chart_POTI_ROLL
            // 
            chartArea4.AxisX.LabelStyle.Enabled = false;
            chartArea4.AxisX.Maximum = 60D;
            chartArea4.AxisX.Minimum = 1D;
            chartArea4.AxisY.Maximum = 1024D;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY.Title = "Value: 0";
            chartArea4.Name = "ChartArea1";
            this.chart_POTI_ROLL.ChartAreas.Add(chartArea4);
            this.chart_POTI_ROLL.Location = new System.Drawing.Point(20, 19);
            this.chart_POTI_ROLL.Name = "chart_POTI_ROLL";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.chart_POTI_ROLL.Series.Add(series4);
            this.chart_POTI_ROLL.Size = new System.Drawing.Size(517, 308);
            this.chart_POTI_ROLL.TabIndex = 0;
            this.chart_POTI_ROLL.Text = "Roll";
            title4.Name = "Title1";
            title4.Text = "Analog Input Roll (Potentiometer)";
            this.chart_POTI_ROLL.Titles.Add(title4);
            // 
            // tabPitch
            // 
            this.tabPitch.BackColor = System.Drawing.Color.Gray;
            this.tabPitch.Controls.Add(this.label13);
            this.tabPitch.Controls.Add(this.txt_poti_pitch_deadzone);
            this.tabPitch.Controls.Add(this.label14);
            this.tabPitch.Controls.Add(this.txt_poti_pitch_middle);
            this.tabPitch.Controls.Add(this.label9);
            this.tabPitch.Controls.Add(this.txt_poti_pitch_max);
            this.tabPitch.Controls.Add(this.label10);
            this.tabPitch.Controls.Add(this.txt_poti_pitch_min);
            this.tabPitch.Controls.Add(this.label3);
            this.tabPitch.Controls.Add(this.txt_ADJ_POTI_PITCH_PWM_MIN);
            this.tabPitch.Controls.Add(this.label2);
            this.tabPitch.Controls.Add(this.txt_ADJ_POTI_PITCH_PWM_MAX);
            this.tabPitch.Controls.Add(this.label1);
            this.tabPitch.Controls.Add(this.txt_ADJ_POTI_PITCH_FORCE_MAX);
            this.tabPitch.Controls.Add(this.chart_FORCE_PITCH);
            this.tabPitch.Controls.Add(this.chart_SPEED_PITCH);
            this.tabPitch.Controls.Add(this.chart_POS_PITCH);
            this.tabPitch.Controls.Add(this.chart_POTI_PITCH);
            this.tabPitch.Location = new System.Drawing.Point(4, 22);
            this.tabPitch.Name = "tabPitch";
            this.tabPitch.Size = new System.Drawing.Size(1374, 482);
            this.tabPitch.TabIndex = 3;
            this.tabPitch.Text = "Pitch";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1114, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Poti Pitch deadzone";
            // 
            // txt_poti_pitch_deadzone
            // 
            this.txt_poti_pitch_deadzone.Location = new System.Drawing.Point(1222, 157);
            this.txt_poti_pitch_deadzone.Name = "txt_poti_pitch_deadzone";
            this.txt_poti_pitch_deadzone.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_pitch_deadzone.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1130, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Poti Pitch middle";
            // 
            // txt_poti_pitch_middle
            // 
            this.txt_poti_pitch_middle.Location = new System.Drawing.Point(1222, 131);
            this.txt_poti_pitch_middle.Name = "txt_poti_pitch_middle";
            this.txt_poti_pitch_middle.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_pitch_middle.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1142, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Poti Pitch max";
            // 
            // txt_poti_pitch_max
            // 
            this.txt_poti_pitch_max.Location = new System.Drawing.Point(1222, 105);
            this.txt_poti_pitch_max.Name = "txt_poti_pitch_max";
            this.txt_poti_pitch_max.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_pitch_max.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1144, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Poti Pitch min";
            // 
            // txt_poti_pitch_min
            // 
            this.txt_poti_pitch_min.Location = new System.Drawing.Point(1222, 79);
            this.txt_poti_pitch_min.Name = "txt_poti_pitch_min";
            this.txt_poti_pitch_min.Size = new System.Drawing.Size(100, 20);
            this.txt_poti_pitch_min.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1130, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Pitch PWM min.";
            // 
            // txt_ADJ_POTI_PITCH_PWM_MIN
            // 
            this.txt_ADJ_POTI_PITCH_PWM_MIN.Location = new System.Drawing.Point(1222, 235);
            this.txt_ADJ_POTI_PITCH_PWM_MIN.Name = "txt_ADJ_POTI_PITCH_PWM_MIN";
            this.txt_ADJ_POTI_PITCH_PWM_MIN.Size = new System.Drawing.Size(100, 20);
            this.txt_ADJ_POTI_PITCH_PWM_MIN.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1130, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Pitch PWM max";
            // 
            // txt_ADJ_POTI_PITCH_PWM_MAX
            // 
            this.txt_ADJ_POTI_PITCH_PWM_MAX.Location = new System.Drawing.Point(1222, 209);
            this.txt_ADJ_POTI_PITCH_PWM_MAX.Name = "txt_ADJ_POTI_PITCH_PWM_MAX";
            this.txt_ADJ_POTI_PITCH_PWM_MAX.Size = new System.Drawing.Size(100, 20);
            this.txt_ADJ_POTI_PITCH_PWM_MAX.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1130, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Pitch max. Force";
            // 
            // txt_ADJ_POTI_PITCH_FORCE_MAX
            // 
            this.txt_ADJ_POTI_PITCH_FORCE_MAX.Location = new System.Drawing.Point(1222, 183);
            this.txt_ADJ_POTI_PITCH_FORCE_MAX.Name = "txt_ADJ_POTI_PITCH_FORCE_MAX";
            this.txt_ADJ_POTI_PITCH_FORCE_MAX.Size = new System.Drawing.Size(100, 20);
            this.txt_ADJ_POTI_PITCH_FORCE_MAX.TabIndex = 40;
            // 
            // chart_FORCE_PITCH
            // 
            chartArea5.AxisX.LabelStyle.Enabled = false;
            chartArea5.AxisX.Maximum = 60D;
            chartArea5.AxisX.Minimum = 1D;
            chartArea5.AxisY.Maximum = 15000D;
            chartArea5.AxisY.Minimum = -15000D;
            chartArea5.AxisY.Title = "Value: 0";
            chartArea5.Name = "ChartArea1";
            this.chart_FORCE_PITCH.ChartAreas.Add(chartArea5);
            this.chart_FORCE_PITCH.Location = new System.Drawing.Point(577, 340);
            this.chart_FORCE_PITCH.Name = "chart_FORCE_PITCH";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Name = "Series1";
            this.chart_FORCE_PITCH.Series.Add(series5);
            this.chart_FORCE_PITCH.Size = new System.Drawing.Size(517, 308);
            this.chart_FORCE_PITCH.TabIndex = 39;
            this.chart_FORCE_PITCH.Text = "Roll";
            title5.Name = "Title1";
            title5.Text = "Force Pitch";
            this.chart_FORCE_PITCH.Titles.Add(title5);
            // 
            // chart_SPEED_PITCH
            // 
            chartArea6.AxisX.LabelStyle.Enabled = false;
            chartArea6.AxisX.Maximum = 60D;
            chartArea6.AxisX.Minimum = 1D;
            chartArea6.AxisY.Maximum = 255D;
            chartArea6.AxisY.Minimum = 0D;
            chartArea6.AxisY.Title = "Value: 0";
            chartArea6.Name = "ChartArea1";
            this.chart_SPEED_PITCH.ChartAreas.Add(chartArea6);
            this.chart_SPEED_PITCH.Location = new System.Drawing.Point(30, 340);
            this.chart_SPEED_PITCH.Name = "chart_SPEED_PITCH";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.chart_SPEED_PITCH.Series.Add(series6);
            this.chart_SPEED_PITCH.Size = new System.Drawing.Size(517, 308);
            this.chart_SPEED_PITCH.TabIndex = 38;
            this.chart_SPEED_PITCH.Text = "Roll";
            title6.Name = "Title1";
            title6.Text = "Speed Pitch (PWM)";
            this.chart_SPEED_PITCH.Titles.Add(title6);
            // 
            // chart_POS_PITCH
            // 
            chartArea7.AxisX.LabelStyle.Enabled = false;
            chartArea7.AxisX.Maximum = 60D;
            chartArea7.AxisX.Minimum = 1D;
            chartArea7.AxisY.Maximum = 32767D;
            chartArea7.AxisY.Minimum = -32768D;
            chartArea7.AxisY.Title = "Value: 0";
            chartArea7.Name = "ChartArea1";
            this.chart_POS_PITCH.ChartAreas.Add(chartArea7);
            this.chart_POS_PITCH.Location = new System.Drawing.Point(577, 26);
            this.chart_POS_PITCH.Name = "chart_POS_PITCH";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Name = "Series1";
            this.chart_POS_PITCH.Series.Add(series7);
            this.chart_POS_PITCH.Size = new System.Drawing.Size(517, 308);
            this.chart_POS_PITCH.TabIndex = 37;
            this.chart_POS_PITCH.Text = "Roll";
            title7.Name = "Title1";
            title7.Text = "Position Pitch";
            this.chart_POS_PITCH.Titles.Add(title7);
            // 
            // chart_POTI_PITCH
            // 
            chartArea8.AxisX.LabelStyle.Enabled = false;
            chartArea8.AxisX.Maximum = 60D;
            chartArea8.AxisX.Minimum = 1D;
            chartArea8.AxisY.Maximum = 1024D;
            chartArea8.AxisY.Minimum = 0D;
            chartArea8.AxisY.Title = "Value: 0";
            chartArea8.Name = "ChartArea1";
            this.chart_POTI_PITCH.ChartAreas.Add(chartArea8);
            this.chart_POTI_PITCH.Location = new System.Drawing.Point(30, 26);
            this.chart_POTI_PITCH.Name = "chart_POTI_PITCH";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Name = "Series1";
            this.chart_POTI_PITCH.Series.Add(series8);
            this.chart_POTI_PITCH.Size = new System.Drawing.Size(517, 308);
            this.chart_POTI_PITCH.TabIndex = 36;
            this.chart_POTI_PITCH.Text = "Roll";
            title8.Name = "Title1";
            title8.Text = "Analog Input Pitch (Potentiometer)";
            this.chart_POTI_PITCH.Titles.Add(title8);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ConnectToPort);
            this.Controls.Add(this.AvailablePortsBox);
            this.Controls.Add(this.ReceivedDataBox);
            this.Name = "Mainform";
            this.Text = "Arduino FFB Yoke App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabButtons.ResumeLayout(false);
            this.tabRoll.ResumeLayout(false);
            this.tabRoll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_ROLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_ROLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POS_ROLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POTI_ROLL)).EndInit();
            this.tabPitch.ResumeLayout(false);
            this.tabPitch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_PITCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_PITCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POS_PITCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_POTI_PITCH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ReceivedDataBox;
        private ComboBox AvailablePortsBox;
        private Button ConnectToPort;
        private TabControl tabControl1;
        private TabPage tabButtons;
        private TabPage tabRoll;
        private TabPage tabPitch;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button_hat_left;
        private Button button_hat_right;
        private Button button_hat_down;
        private Button button_hat_up;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button0;
        private Button button6;
        private Button button_ADJ_ENDSWITCH_ROLL_LEFT;
        private Button button_ADJ_ENDSWITCH_ROLL_RIGHT;
        private Button button_ADJ_ENDSWITCH_PITCH_DOWN;
        private Button button_ADJ_ENDSWITCH_PITCH_UP;
        private Button button_ADJ_BUTTON_CALIBRATION;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_POTI_ROLL;
        private Label label7;
        private TextBox txt_poti_roll_max;
        private Label label8;
        private TextBox txt_poti_roll_min;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_POS_ROLL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SPEED_ROLL;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_FORCE_ROLL;
        private Label label4;
        private TextBox txt_ADJ_POTI_ROLL_PWM_MIN;
        private Label label5;
        private TextBox txt_ADJ_POTI_ROLL_PWM_MAX;
        private Label label6;
        private TextBox txt_ADJ_POTI_ROLL_FORCE_MAX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_FORCE_PITCH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SPEED_PITCH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_POS_PITCH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_POTI_PITCH;
        private Label label3;
        private TextBox txt_ADJ_POTI_PITCH_PWM_MIN;
        private Label label2;
        private TextBox txt_ADJ_POTI_PITCH_PWM_MAX;
        private Label label1;
        private TextBox txt_ADJ_POTI_PITCH_FORCE_MAX;
        private Label label9;
        private TextBox txt_poti_pitch_max;
        private Label label10;
        private TextBox txt_poti_pitch_min;
        private Label label11;
        private TextBox txt_poti_roll_deadzone;
        private Label label12;
        private TextBox txt_poti_roll_middle;
        private Label label13;
        private TextBox txt_poti_pitch_deadzone;
        private Label label14;
        private TextBox txt_poti_pitch_middle;
    }
}