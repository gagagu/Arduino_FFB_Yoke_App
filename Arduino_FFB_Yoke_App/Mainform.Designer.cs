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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btDisconnect = new System.Windows.Forms.Button();
      this.cbAvailablePortsBox = new System.Windows.Forms.ComboBox();
      this.btRefreshPortList = new System.Windows.Forms.Button();
      this.btConnectToPort = new System.Windows.Forms.Button();
      this.tabControlMain = new System.Windows.Forms.TabControl();
      this.tabPageMainSettings = new System.Windows.Forms.TabPage();
      this.tabControlMainSettings = new System.Windows.Forms.TabControl();
      this.tabPageMainSettingsRoll = new System.Windows.Forms.TabPage();
      this.label118 = new System.Windows.Forms.Label();
      this.label117 = new System.Windows.Forms.Label();
      this.label116 = new System.Windows.Forms.Label();
      this.label115 = new System.Windows.Forms.Label();
      this.label114 = new System.Windows.Forms.Label();
      this.label113 = new System.Windows.Forms.Label();
      this.label112 = new System.Windows.Forms.Label();
      this.lb_ROLL_PWM_MAX = new System.Windows.Forms.Label();
      this.lb_ROLL_PWM_MIN = new System.Windows.Forms.Label();
      this.tb_ROLL_PWM_MIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_FORCE_MAX = new System.Windows.Forms.Label();
      this.tb_ROLL_FORCE_MAX = new System.Windows.Forms.TrackBar();
      this.label61 = new System.Windows.Forms.Label();
      this.label62 = new System.Windows.Forms.Label();
      this.label63 = new System.Windows.Forms.Label();
      this.label64 = new System.Windows.Forms.Label();
      this.label65 = new System.Windows.Forms.Label();
      this.lb_ROLL_DAMPER_MAX_VELOCITY = new System.Windows.Forms.Label();
      this.tb_ROLL_DAMPER_MAX_VELOCITY = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_INERTIA_MAX_ACCELERATION = new System.Windows.Forms.Label();
      this.label68 = new System.Windows.Forms.Label();
      this.label69 = new System.Windows.Forms.Label();
      this.label70 = new System.Windows.Forms.Label();
      this.label71 = new System.Windows.Forms.Label();
      this.label72 = new System.Windows.Forms.Label();
      this.tb_ROLL_INERTIA_MAX_ACCELERATION = new System.Windows.Forms.TrackBar();
      this.label73 = new System.Windows.Forms.Label();
      this.label74 = new System.Windows.Forms.Label();
      this.label75 = new System.Windows.Forms.Label();
      this.label76 = new System.Windows.Forms.Label();
      this.label77 = new System.Windows.Forms.Label();
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE = new System.Windows.Forms.Label();
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_FRICTION_GAIN = new System.Windows.Forms.Label();
      this.label80 = new System.Windows.Forms.Label();
      this.label81 = new System.Windows.Forms.Label();
      this.label82 = new System.Windows.Forms.Label();
      this.label83 = new System.Windows.Forms.Label();
      this.label84 = new System.Windows.Forms.Label();
      this.tb_ROLL_FRICTION_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_INERTIA_GAIN = new System.Windows.Forms.Label();
      this.label92 = new System.Windows.Forms.Label();
      this.label93 = new System.Windows.Forms.Label();
      this.label94 = new System.Windows.Forms.Label();
      this.label95 = new System.Windows.Forms.Label();
      this.label96 = new System.Windows.Forms.Label();
      this.tb_ROLL_INERTIA_GAIN = new System.Windows.Forms.TrackBar();
      this.label97 = new System.Windows.Forms.Label();
      this.label98 = new System.Windows.Forms.Label();
      this.label99 = new System.Windows.Forms.Label();
      this.label100 = new System.Windows.Forms.Label();
      this.label101 = new System.Windows.Forms.Label();
      this.lb_ROLL_DAMPER_GAIN = new System.Windows.Forms.Label();
      this.tb_ROLL_DAMPER_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_SPRING_GAIN = new System.Windows.Forms.Label();
      this.label104 = new System.Windows.Forms.Label();
      this.label105 = new System.Windows.Forms.Label();
      this.label106 = new System.Windows.Forms.Label();
      this.label107 = new System.Windows.Forms.Label();
      this.label108 = new System.Windows.Forms.Label();
      this.tb_ROLL_SPRING_GAIN = new System.Windows.Forms.TrackBar();
      this.label37 = new System.Windows.Forms.Label();
      this.label38 = new System.Windows.Forms.Label();
      this.label39 = new System.Windows.Forms.Label();
      this.label40 = new System.Windows.Forms.Label();
      this.label41 = new System.Windows.Forms.Label();
      this.lb_ROLL_SAWTOOTH_UP_GAIN = new System.Windows.Forms.Label();
      this.tb_ROLL_SAWTOOTH_UP_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_SAWTOOT_DOWN_GAIN = new System.Windows.Forms.Label();
      this.label44 = new System.Windows.Forms.Label();
      this.label45 = new System.Windows.Forms.Label();
      this.label46 = new System.Windows.Forms.Label();
      this.label47 = new System.Windows.Forms.Label();
      this.label48 = new System.Windows.Forms.Label();
      this.tb_ROLL_SAWTOOT_DOWN_GAIN = new System.Windows.Forms.TrackBar();
      this.label49 = new System.Windows.Forms.Label();
      this.label50 = new System.Windows.Forms.Label();
      this.label51 = new System.Windows.Forms.Label();
      this.label52 = new System.Windows.Forms.Label();
      this.label53 = new System.Windows.Forms.Label();
      this.lb_ROLL_TRIANGLE_GAIN = new System.Windows.Forms.Label();
      this.tb_ROLL_TRIANGLE_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_SIN_GAIN = new System.Windows.Forms.Label();
      this.label56 = new System.Windows.Forms.Label();
      this.label57 = new System.Windows.Forms.Label();
      this.label58 = new System.Windows.Forms.Label();
      this.label59 = new System.Windows.Forms.Label();
      this.label60 = new System.Windows.Forms.Label();
      this.tb_ROLL_SIN_GAIN = new System.Windows.Forms.TrackBar();
      this.label16 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.label22 = new System.Windows.Forms.Label();
      this.label23 = new System.Windows.Forms.Label();
      this.label24 = new System.Windows.Forms.Label();
      this.lb_ROLL_SQUARE_GAIN = new System.Windows.Forms.Label();
      this.tb_ROLL_SQUARE_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_RAMP_GAIN = new System.Windows.Forms.Label();
      this.label32 = new System.Windows.Forms.Label();
      this.label33 = new System.Windows.Forms.Label();
      this.label34 = new System.Windows.Forms.Label();
      this.label35 = new System.Windows.Forms.Label();
      this.label36 = new System.Windows.Forms.Label();
      this.tb_ROLL_RAMP_GAIN = new System.Windows.Forms.TrackBar();
      this.label25 = new System.Windows.Forms.Label();
      this.label26 = new System.Windows.Forms.Label();
      this.label27 = new System.Windows.Forms.Label();
      this.label28 = new System.Windows.Forms.Label();
      this.label29 = new System.Windows.Forms.Label();
      this.lb_ROLL_CONSTANT_GAIN = new System.Windows.Forms.Label();
      this.tb_ROLL_CONSTANT_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_ROLL_TOTAL_GAIN = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.label17 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.tb_ROLL_TOTAL_GAIN = new System.Windows.Forms.TrackBar();
      this.tb_ROLL_PWM_MAX = new System.Windows.Forms.TrackBar();
      this.tabPageMainSettingsPitch = new System.Windows.Forms.TabPage();
      this.label119 = new System.Windows.Forms.Label();
      this.label120 = new System.Windows.Forms.Label();
      this.label121 = new System.Windows.Forms.Label();
      this.label122 = new System.Windows.Forms.Label();
      this.label123 = new System.Windows.Forms.Label();
      this.label124 = new System.Windows.Forms.Label();
      this.label125 = new System.Windows.Forms.Label();
      this.lb_PITCH_PWM_MAX = new System.Windows.Forms.Label();
      this.lb_PITCH_PWM_MIN = new System.Windows.Forms.Label();
      this.tb_PITCH_PWM_MIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_FORCE_MAX = new System.Windows.Forms.Label();
      this.tb_PITCH_FORCE_MAX = new System.Windows.Forms.TrackBar();
      this.label129 = new System.Windows.Forms.Label();
      this.label130 = new System.Windows.Forms.Label();
      this.label131 = new System.Windows.Forms.Label();
      this.label132 = new System.Windows.Forms.Label();
      this.label133 = new System.Windows.Forms.Label();
      this.lb_PITCH_DAMPER_MAX_VELOCITY = new System.Windows.Forms.Label();
      this.tb_PITCH_DAMPER_MAX_VELOCITY = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_INERTIA_MAX_ACCELERATION = new System.Windows.Forms.Label();
      this.label136 = new System.Windows.Forms.Label();
      this.label137 = new System.Windows.Forms.Label();
      this.label138 = new System.Windows.Forms.Label();
      this.label139 = new System.Windows.Forms.Label();
      this.label140 = new System.Windows.Forms.Label();
      this.tb_PITCH_INERTIA_MAX_ACCELERATION = new System.Windows.Forms.TrackBar();
      this.label141 = new System.Windows.Forms.Label();
      this.label142 = new System.Windows.Forms.Label();
      this.label143 = new System.Windows.Forms.Label();
      this.label144 = new System.Windows.Forms.Label();
      this.label145 = new System.Windows.Forms.Label();
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE = new System.Windows.Forms.Label();
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_FRICTION_GAIN = new System.Windows.Forms.Label();
      this.label148 = new System.Windows.Forms.Label();
      this.label149 = new System.Windows.Forms.Label();
      this.label150 = new System.Windows.Forms.Label();
      this.label151 = new System.Windows.Forms.Label();
      this.label152 = new System.Windows.Forms.Label();
      this.tb_PITCH_FRICTION_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_INERTIA_GAIN = new System.Windows.Forms.Label();
      this.label160 = new System.Windows.Forms.Label();
      this.label161 = new System.Windows.Forms.Label();
      this.label162 = new System.Windows.Forms.Label();
      this.label163 = new System.Windows.Forms.Label();
      this.label164 = new System.Windows.Forms.Label();
      this.tb_PITCH_INERTIA_GAIN = new System.Windows.Forms.TrackBar();
      this.label165 = new System.Windows.Forms.Label();
      this.label166 = new System.Windows.Forms.Label();
      this.label167 = new System.Windows.Forms.Label();
      this.label168 = new System.Windows.Forms.Label();
      this.label169 = new System.Windows.Forms.Label();
      this.lb_PITCH_DAMPER_GAIN = new System.Windows.Forms.Label();
      this.tb_PITCH_DAMPER_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_SPRING_GAIN = new System.Windows.Forms.Label();
      this.label172 = new System.Windows.Forms.Label();
      this.label173 = new System.Windows.Forms.Label();
      this.label174 = new System.Windows.Forms.Label();
      this.label175 = new System.Windows.Forms.Label();
      this.label176 = new System.Windows.Forms.Label();
      this.tb_PITCH_SPRING_GAIN = new System.Windows.Forms.TrackBar();
      this.label177 = new System.Windows.Forms.Label();
      this.label178 = new System.Windows.Forms.Label();
      this.label179 = new System.Windows.Forms.Label();
      this.label180 = new System.Windows.Forms.Label();
      this.label181 = new System.Windows.Forms.Label();
      this.lb_PITCH_SAWTOOTH_UP_GAIN = new System.Windows.Forms.Label();
      this.tb_PITCH_SAWTOOTH_UP_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_SAWTOOT_DOWN_GAIN = new System.Windows.Forms.Label();
      this.label184 = new System.Windows.Forms.Label();
      this.label185 = new System.Windows.Forms.Label();
      this.label186 = new System.Windows.Forms.Label();
      this.label187 = new System.Windows.Forms.Label();
      this.label188 = new System.Windows.Forms.Label();
      this.tb_PITCH_SAWTOOT_DOWN_GAIN = new System.Windows.Forms.TrackBar();
      this.label189 = new System.Windows.Forms.Label();
      this.label190 = new System.Windows.Forms.Label();
      this.label191 = new System.Windows.Forms.Label();
      this.label192 = new System.Windows.Forms.Label();
      this.label193 = new System.Windows.Forms.Label();
      this.lb_PITCH_TRIANGLE_GAIN = new System.Windows.Forms.Label();
      this.tb_PITCH_TRIANGLE_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_SIN_GAIN = new System.Windows.Forms.Label();
      this.label196 = new System.Windows.Forms.Label();
      this.label197 = new System.Windows.Forms.Label();
      this.label198 = new System.Windows.Forms.Label();
      this.label199 = new System.Windows.Forms.Label();
      this.label200 = new System.Windows.Forms.Label();
      this.tb_PITCH_SIN_GAIN = new System.Windows.Forms.TrackBar();
      this.label201 = new System.Windows.Forms.Label();
      this.label202 = new System.Windows.Forms.Label();
      this.label203 = new System.Windows.Forms.Label();
      this.label204 = new System.Windows.Forms.Label();
      this.label205 = new System.Windows.Forms.Label();
      this.lb_PITCH_SQUARE_GAIN = new System.Windows.Forms.Label();
      this.tb_PITCH_SQUARE_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_RAMP_GAIN = new System.Windows.Forms.Label();
      this.label208 = new System.Windows.Forms.Label();
      this.label209 = new System.Windows.Forms.Label();
      this.label210 = new System.Windows.Forms.Label();
      this.label211 = new System.Windows.Forms.Label();
      this.label212 = new System.Windows.Forms.Label();
      this.tb_PITCH_RAMP_GAIN = new System.Windows.Forms.TrackBar();
      this.label213 = new System.Windows.Forms.Label();
      this.label214 = new System.Windows.Forms.Label();
      this.label215 = new System.Windows.Forms.Label();
      this.label216 = new System.Windows.Forms.Label();
      this.label217 = new System.Windows.Forms.Label();
      this.lb_PITCH_CONSTANT_GAIN = new System.Windows.Forms.Label();
      this.tb_PITCH_CONSTANT_GAIN = new System.Windows.Forms.TrackBar();
      this.lb_PITCH_TOTAL_GAIN = new System.Windows.Forms.Label();
      this.label220 = new System.Windows.Forms.Label();
      this.label221 = new System.Windows.Forms.Label();
      this.label222 = new System.Windows.Forms.Label();
      this.label223 = new System.Windows.Forms.Label();
      this.label224 = new System.Windows.Forms.Label();
      this.tb_PITCH_TOTAL_GAIN = new System.Windows.Forms.TrackBar();
      this.tb_PITCH_PWM_MAX = new System.Windows.Forms.TrackBar();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btSettingsClearEeprom = new System.Windows.Forms.Button();
      this.btSettingsWriteToEEProm = new System.Windows.Forms.Button();
      this.btSettingsWriteToYoke = new System.Windows.Forms.Button();
      this.btSettingsReadFromYoke = new System.Windows.Forms.Button();
      this.tabPageMainDebug = new System.Windows.Forms.TabPage();
      this.btDebugStop = new System.Windows.Forms.Button();
      this.btDebugStart = new System.Windows.Forms.Button();
      this.tabControlDebug = new System.Windows.Forms.TabControl();
      this.tabButtons = new System.Windows.Forms.TabPage();
      this.label229 = new System.Windows.Forms.Label();
      this.tb_sensor_left_green = new System.Windows.Forms.PictureBox();
      this.tb_sensor_left_black = new System.Windows.Forms.PictureBox();
      this.label228 = new System.Windows.Forms.Label();
      this.tb_sensor_right_green = new System.Windows.Forms.PictureBox();
      this.tb_sensor_right_black = new System.Windows.Forms.PictureBox();
      this.label227 = new System.Windows.Forms.Label();
      this.tb_sensor_up_green = new System.Windows.Forms.PictureBox();
      this.tb_sensor_up_black = new System.Windows.Forms.PictureBox();
      this.label226 = new System.Windows.Forms.Label();
      this.tb_sensor_down_green = new System.Windows.Forms.PictureBox();
      this.tb_sensor_down_black = new System.Windows.Forms.PictureBox();
      this.label225 = new System.Windows.Forms.Label();
      this.tb_button_calibration_green = new System.Windows.Forms.PictureBox();
      this.tb_button_calibration_black = new System.Windows.Forms.PictureBox();
      this.cb_yoke_7 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_13 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_15 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_14 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_12 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_11 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_10 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_3 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_2 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_0 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_1 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_4 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_9 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_6 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_5 = new System.Windows.Forms.CheckBox();
      this.cb_yoke_8 = new System.Windows.Forms.CheckBox();
      this.pbDebugYoke = new System.Windows.Forms.PictureBox();
      this.tabRoll = new System.Windows.Forms.TabPage();
      this.chart_FORCE_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart_COUNTER_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart_SPEED_ROLL = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.tabPitch = new System.Windows.Forms.TabPage();
      this.chart_FORCE_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart_COUNTER_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart_SPEED_PITCH = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
      this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.timerReplySettingsTimeout = new System.Windows.Forms.Timer(this.components);
      this.groupBox1.SuspendLayout();
      this.tabControlMain.SuspendLayout();
      this.tabPageMainSettings.SuspendLayout();
      this.tabControlMainSettings.SuspendLayout();
      this.tabPageMainSettingsRoll.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_PWM_MIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_FORCE_MAX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_DAMPER_MAX_VELOCITY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_INERTIA_MAX_ACCELERATION)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_FRICTION_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_INERTIA_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_DAMPER_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SPRING_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SAWTOOTH_UP_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SAWTOOT_DOWN_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_TRIANGLE_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SIN_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SQUARE_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_RAMP_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_CONSTANT_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_TOTAL_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_PWM_MAX)).BeginInit();
      this.tabPageMainSettingsPitch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_PWM_MIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_FORCE_MAX)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_DAMPER_MAX_VELOCITY)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_INERTIA_MAX_ACCELERATION)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_FRICTION_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_INERTIA_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_DAMPER_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SPRING_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SAWTOOTH_UP_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SAWTOOT_DOWN_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_TRIANGLE_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SIN_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SQUARE_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_RAMP_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_CONSTANT_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_TOTAL_GAIN)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_PWM_MAX)).BeginInit();
      this.groupBox3.SuspendLayout();
      this.tabPageMainDebug.SuspendLayout();
      this.tabControlDebug.SuspendLayout();
      this.tabButtons.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_left_green)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_left_black)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_right_green)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_right_black)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_up_green)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_up_black)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_down_green)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_down_black)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_button_calibration_green)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_button_calibration_black)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbDebugYoke)).BeginInit();
      this.tabRoll.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_ROLL)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_COUNTER_ROLL)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_ROLL)).BeginInit();
      this.tabPitch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_PITCH)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_COUNTER_PITCH)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_PITCH)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.mainMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btDisconnect);
      this.groupBox1.Controls.Add(this.cbAvailablePortsBox);
      this.groupBox1.Controls.Add(this.btRefreshPortList);
      this.groupBox1.Controls.Add(this.btConnectToPort);
      this.groupBox1.Location = new System.Drawing.Point(5, 26);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(502, 50);
      this.groupBox1.TabIndex = 6;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "USB Settings";
      // 
      // btDisconnect
      // 
      this.btDisconnect.Enabled = false;
      this.btDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btDisconnect.Image")));
      this.btDisconnect.Location = new System.Drawing.Point(461, 15);
      this.btDisconnect.Name = "btDisconnect";
      this.btDisconnect.Size = new System.Drawing.Size(27, 26);
      this.btDisconnect.TabIndex = 4;
      this.btDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.mainToolTip.SetToolTip(this.btDisconnect, "Disconnect from Port");
      this.btDisconnect.UseVisualStyleBackColor = true;
      this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
      // 
      // cbAvailablePortsBox
      // 
      this.cbAvailablePortsBox.FormattingEnabled = true;
      this.cbAvailablePortsBox.Location = new System.Drawing.Point(6, 17);
      this.cbAvailablePortsBox.Name = "cbAvailablePortsBox";
      this.cbAvailablePortsBox.Size = new System.Drawing.Size(385, 21);
      this.cbAvailablePortsBox.TabIndex = 1;
      this.mainToolTip.SetToolTip(this.cbAvailablePortsBox, "Available USB Ports");
      // 
      // btRefreshPortList
      // 
      this.btRefreshPortList.AutoSize = true;
      this.btRefreshPortList.Cursor = System.Windows.Forms.Cursors.Default;
      this.btRefreshPortList.Image = ((System.Drawing.Image)(resources.GetObject("btRefreshPortList.Image")));
      this.btRefreshPortList.Location = new System.Drawing.Point(396, 15);
      this.btRefreshPortList.Name = "btRefreshPortList";
      this.btRefreshPortList.Size = new System.Drawing.Size(27, 26);
      this.btRefreshPortList.TabIndex = 2;
      this.btRefreshPortList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.mainToolTip.SetToolTip(this.btRefreshPortList, "Refresh");
      this.btRefreshPortList.UseVisualStyleBackColor = true;
      this.btRefreshPortList.Click += new System.EventHandler(this.btRefreshPortList_Click);
      // 
      // btConnectToPort
      // 
      this.btConnectToPort.Image = ((System.Drawing.Image)(resources.GetObject("btConnectToPort.Image")));
      this.btConnectToPort.Location = new System.Drawing.Point(428, 15);
      this.btConnectToPort.Name = "btConnectToPort";
      this.btConnectToPort.Size = new System.Drawing.Size(27, 26);
      this.btConnectToPort.TabIndex = 3;
      this.btConnectToPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.mainToolTip.SetToolTip(this.btConnectToPort, "Connect to selected USB Port");
      this.btConnectToPort.UseVisualStyleBackColor = true;
      this.btConnectToPort.Click += new System.EventHandler(this.ConnectToPort_Click);
      // 
      // tabControlMain
      // 
      this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControlMain.Controls.Add(this.tabPageMainSettings);
      this.tabControlMain.Controls.Add(this.tabPageMainDebug);
      this.tabControlMain.Location = new System.Drawing.Point(4, 82);
      this.tabControlMain.Name = "tabControlMain";
      this.tabControlMain.SelectedIndex = 0;
      this.tabControlMain.Size = new System.Drawing.Size(1056, 675);
      this.tabControlMain.TabIndex = 9;
      // 
      // tabPageMainSettings
      // 
      this.tabPageMainSettings.BackColor = System.Drawing.Color.Transparent;
      this.tabPageMainSettings.Controls.Add(this.tabControlMainSettings);
      this.tabPageMainSettings.Controls.Add(this.groupBox3);
      this.tabPageMainSettings.Location = new System.Drawing.Point(4, 22);
      this.tabPageMainSettings.Name = "tabPageMainSettings";
      this.tabPageMainSettings.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMainSettings.Size = new System.Drawing.Size(1048, 649);
      this.tabPageMainSettings.TabIndex = 0;
      this.tabPageMainSettings.Text = "Settings";
      // 
      // tabControlMainSettings
      // 
      this.tabControlMainSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.tabControlMainSettings.Controls.Add(this.tabPageMainSettingsRoll);
      this.tabControlMainSettings.Controls.Add(this.tabPageMainSettingsPitch);
      this.tabControlMainSettings.Location = new System.Drawing.Point(6, 8);
      this.tabControlMainSettings.Name = "tabControlMainSettings";
      this.tabControlMainSettings.SelectedIndex = 0;
      this.tabControlMainSettings.Size = new System.Drawing.Size(863, 627);
      this.tabControlMainSettings.TabIndex = 2;
      // 
      // tabPageMainSettingsRoll
      // 
      this.tabPageMainSettingsRoll.BackColor = System.Drawing.Color.Gainsboro;
      this.tabPageMainSettingsRoll.Controls.Add(this.label118);
      this.tabPageMainSettingsRoll.Controls.Add(this.label117);
      this.tabPageMainSettingsRoll.Controls.Add(this.label116);
      this.tabPageMainSettingsRoll.Controls.Add(this.label115);
      this.tabPageMainSettingsRoll.Controls.Add(this.label114);
      this.tabPageMainSettingsRoll.Controls.Add(this.label113);
      this.tabPageMainSettingsRoll.Controls.Add(this.label112);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_PWM_MAX);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_PWM_MIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_PWM_MIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_FORCE_MAX);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_FORCE_MAX);
      this.tabPageMainSettingsRoll.Controls.Add(this.label61);
      this.tabPageMainSettingsRoll.Controls.Add(this.label62);
      this.tabPageMainSettingsRoll.Controls.Add(this.label63);
      this.tabPageMainSettingsRoll.Controls.Add(this.label64);
      this.tabPageMainSettingsRoll.Controls.Add(this.label65);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_DAMPER_MAX_VELOCITY);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_DAMPER_MAX_VELOCITY);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_INERTIA_MAX_ACCELERATION);
      this.tabPageMainSettingsRoll.Controls.Add(this.label68);
      this.tabPageMainSettingsRoll.Controls.Add(this.label69);
      this.tabPageMainSettingsRoll.Controls.Add(this.label70);
      this.tabPageMainSettingsRoll.Controls.Add(this.label71);
      this.tabPageMainSettingsRoll.Controls.Add(this.label72);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_INERTIA_MAX_ACCELERATION);
      this.tabPageMainSettingsRoll.Controls.Add(this.label73);
      this.tabPageMainSettingsRoll.Controls.Add(this.label74);
      this.tabPageMainSettingsRoll.Controls.Add(this.label75);
      this.tabPageMainSettingsRoll.Controls.Add(this.label76);
      this.tabPageMainSettingsRoll.Controls.Add(this.label77);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_FRICTION_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label80);
      this.tabPageMainSettingsRoll.Controls.Add(this.label81);
      this.tabPageMainSettingsRoll.Controls.Add(this.label82);
      this.tabPageMainSettingsRoll.Controls.Add(this.label83);
      this.tabPageMainSettingsRoll.Controls.Add(this.label84);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_FRICTION_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_INERTIA_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label92);
      this.tabPageMainSettingsRoll.Controls.Add(this.label93);
      this.tabPageMainSettingsRoll.Controls.Add(this.label94);
      this.tabPageMainSettingsRoll.Controls.Add(this.label95);
      this.tabPageMainSettingsRoll.Controls.Add(this.label96);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_INERTIA_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label97);
      this.tabPageMainSettingsRoll.Controls.Add(this.label98);
      this.tabPageMainSettingsRoll.Controls.Add(this.label99);
      this.tabPageMainSettingsRoll.Controls.Add(this.label100);
      this.tabPageMainSettingsRoll.Controls.Add(this.label101);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_DAMPER_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_DAMPER_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_SPRING_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label104);
      this.tabPageMainSettingsRoll.Controls.Add(this.label105);
      this.tabPageMainSettingsRoll.Controls.Add(this.label106);
      this.tabPageMainSettingsRoll.Controls.Add(this.label107);
      this.tabPageMainSettingsRoll.Controls.Add(this.label108);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_SPRING_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label37);
      this.tabPageMainSettingsRoll.Controls.Add(this.label38);
      this.tabPageMainSettingsRoll.Controls.Add(this.label39);
      this.tabPageMainSettingsRoll.Controls.Add(this.label40);
      this.tabPageMainSettingsRoll.Controls.Add(this.label41);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_SAWTOOTH_UP_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_SAWTOOTH_UP_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_SAWTOOT_DOWN_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label44);
      this.tabPageMainSettingsRoll.Controls.Add(this.label45);
      this.tabPageMainSettingsRoll.Controls.Add(this.label46);
      this.tabPageMainSettingsRoll.Controls.Add(this.label47);
      this.tabPageMainSettingsRoll.Controls.Add(this.label48);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_SAWTOOT_DOWN_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label49);
      this.tabPageMainSettingsRoll.Controls.Add(this.label50);
      this.tabPageMainSettingsRoll.Controls.Add(this.label51);
      this.tabPageMainSettingsRoll.Controls.Add(this.label52);
      this.tabPageMainSettingsRoll.Controls.Add(this.label53);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_TRIANGLE_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_TRIANGLE_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_SIN_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label56);
      this.tabPageMainSettingsRoll.Controls.Add(this.label57);
      this.tabPageMainSettingsRoll.Controls.Add(this.label58);
      this.tabPageMainSettingsRoll.Controls.Add(this.label59);
      this.tabPageMainSettingsRoll.Controls.Add(this.label60);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_SIN_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label16);
      this.tabPageMainSettingsRoll.Controls.Add(this.label21);
      this.tabPageMainSettingsRoll.Controls.Add(this.label22);
      this.tabPageMainSettingsRoll.Controls.Add(this.label23);
      this.tabPageMainSettingsRoll.Controls.Add(this.label24);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_SQUARE_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_SQUARE_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_RAMP_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label32);
      this.tabPageMainSettingsRoll.Controls.Add(this.label33);
      this.tabPageMainSettingsRoll.Controls.Add(this.label34);
      this.tabPageMainSettingsRoll.Controls.Add(this.label35);
      this.tabPageMainSettingsRoll.Controls.Add(this.label36);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_RAMP_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label25);
      this.tabPageMainSettingsRoll.Controls.Add(this.label26);
      this.tabPageMainSettingsRoll.Controls.Add(this.label27);
      this.tabPageMainSettingsRoll.Controls.Add(this.label28);
      this.tabPageMainSettingsRoll.Controls.Add(this.label29);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_CONSTANT_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_CONSTANT_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.lb_ROLL_TOTAL_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.label20);
      this.tabPageMainSettingsRoll.Controls.Add(this.label18);
      this.tabPageMainSettingsRoll.Controls.Add(this.label17);
      this.tabPageMainSettingsRoll.Controls.Add(this.label15);
      this.tabPageMainSettingsRoll.Controls.Add(this.label11);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_TOTAL_GAIN);
      this.tabPageMainSettingsRoll.Controls.Add(this.tb_ROLL_PWM_MAX);
      this.tabPageMainSettingsRoll.Location = new System.Drawing.Point(4, 22);
      this.tabPageMainSettingsRoll.Name = "tabPageMainSettingsRoll";
      this.tabPageMainSettingsRoll.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMainSettingsRoll.Size = new System.Drawing.Size(855, 601);
      this.tabPageMainSettingsRoll.TabIndex = 0;
      this.tabPageMainSettingsRoll.Text = "Roll";
      // 
      // label118
      // 
      this.label118.AutoSize = true;
      this.label118.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label118.Location = new System.Drawing.Point(810, 52);
      this.label118.Name = "label118";
      this.label118.Size = new System.Drawing.Size(25, 13);
      this.label118.TabIndex = 149;
      this.label118.Text = "255";
      // 
      // label117
      // 
      this.label117.AutoSize = true;
      this.label117.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label117.Location = new System.Drawing.Point(524, 52);
      this.label117.Name = "label117";
      this.label117.Size = new System.Drawing.Size(25, 13);
      this.label117.TabIndex = 148;
      this.label117.Text = "255";
      // 
      // label116
      // 
      this.label116.AutoSize = true;
      this.label116.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label116.Location = new System.Drawing.Point(592, 52);
      this.label116.Name = "label116";
      this.label116.Size = new System.Drawing.Size(13, 13);
      this.label116.TabIndex = 147;
      this.label116.Text = "0";
      // 
      // label115
      // 
      this.label115.AutoSize = true;
      this.label115.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label115.Location = new System.Drawing.Point(305, 52);
      this.label115.Name = "label115";
      this.label115.Size = new System.Drawing.Size(13, 13);
      this.label115.TabIndex = 146;
      this.label115.Text = "0";
      // 
      // label114
      // 
      this.label114.AutoSize = true;
      this.label114.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label114.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label114.Location = new System.Drawing.Point(121, 52);
      this.label114.Name = "label114";
      this.label114.Size = new System.Drawing.Size(37, 13);
      this.label114.TabIndex = 145;
      this.label114.Text = "16250";
      // 
      // label113
      // 
      this.label113.AutoSize = true;
      this.label113.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label113.Location = new System.Drawing.Point(21, 52);
      this.label113.Name = "label113";
      this.label113.Size = new System.Drawing.Size(13, 13);
      this.label113.TabIndex = 144;
      this.label113.Text = "0";
      // 
      // label112
      // 
      this.label112.AutoSize = true;
      this.label112.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label112.Location = new System.Drawing.Point(225, 52);
      this.label112.Name = "label112";
      this.label112.Size = new System.Drawing.Size(37, 13);
      this.label112.TabIndex = 143;
      this.label112.Text = "32500";
      // 
      // lb_ROLL_PWM_MAX
      // 
      this.lb_ROLL_PWM_MAX.AutoSize = true;
      this.lb_ROLL_PWM_MAX.Location = new System.Drawing.Point(661, 6);
      this.lb_ROLL_PWM_MAX.Name = "lb_ROLL_PWM_MAX";
      this.lb_ROLL_PWM_MAX.Size = new System.Drawing.Size(90, 13);
      this.lb_ROLL_PWM_MAX.TabIndex = 142;
      this.lb_ROLL_PWM_MAX.Text = "Max Motor Power";
      // 
      // lb_ROLL_PWM_MIN
      // 
      this.lb_ROLL_PWM_MIN.AutoSize = true;
      this.lb_ROLL_PWM_MIN.Location = new System.Drawing.Point(373, 6);
      this.lb_ROLL_PWM_MIN.Name = "lb_ROLL_PWM_MIN";
      this.lb_ROLL_PWM_MIN.Size = new System.Drawing.Size(92, 13);
      this.lb_ROLL_PWM_MIN.TabIndex = 140;
      this.lb_ROLL_PWM_MIN.Text = "Start Motor Power";
      // 
      // tb_ROLL_PWM_MIN
      // 
      this.tb_ROLL_PWM_MIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_PWM_MIN.LargeChange = 10;
      this.tb_ROLL_PWM_MIN.Location = new System.Drawing.Point(298, 21);
      this.tb_ROLL_PWM_MIN.Maximum = 255;
      this.tb_ROLL_PWM_MIN.Name = "tb_ROLL_PWM_MIN";
      this.tb_ROLL_PWM_MIN.Size = new System.Drawing.Size(250, 45);
      this.tb_ROLL_PWM_MIN.TabIndex = 5;
      this.tb_ROLL_PWM_MIN.TickFrequency = 15;
      this.tb_ROLL_PWM_MIN.Scroll += new System.EventHandler(this.tb_ROLL_PWM_MIN_Scroll);
      this.tb_ROLL_PWM_MIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_FORCE_MAX
      // 
      this.lb_ROLL_FORCE_MAX.AutoSize = true;
      this.lb_ROLL_FORCE_MAX.Location = new System.Drawing.Point(79, 6);
      this.lb_ROLL_FORCE_MAX.Name = "lb_ROLL_FORCE_MAX";
      this.lb_ROLL_FORCE_MAX.Size = new System.Drawing.Size(106, 13);
      this.lb_ROLL_FORCE_MAX.TabIndex = 138;
      this.lb_ROLL_FORCE_MAX.Text = "Max Accepted Force";
      // 
      // tb_ROLL_FORCE_MAX
      // 
      this.tb_ROLL_FORCE_MAX.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_FORCE_MAX.LargeChange = 1000;
      this.tb_ROLL_FORCE_MAX.Location = new System.Drawing.Point(13, 21);
      this.tb_ROLL_FORCE_MAX.Maximum = 32500;
      this.tb_ROLL_FORCE_MAX.Name = "tb_ROLL_FORCE_MAX";
      this.tb_ROLL_FORCE_MAX.Size = new System.Drawing.Size(250, 45);
      this.tb_ROLL_FORCE_MAX.SmallChange = 100;
      this.tb_ROLL_FORCE_MAX.TabIndex = 4;
      this.tb_ROLL_FORCE_MAX.TickFrequency = 1500;
      this.tb_ROLL_FORCE_MAX.Scroll += new System.EventHandler(this.tb_ROLL_FORCE_MAX_Scroll);
      this.tb_ROLL_FORCE_MAX.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label61
      // 
      this.label61.AutoSize = true;
      this.label61.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label61.Location = new System.Drawing.Point(539, 561);
      this.label61.Name = "label61";
      this.label61.Size = new System.Drawing.Size(25, 13);
      this.label61.TabIndex = 136;
      this.label61.Text = "250";
      // 
      // label62
      // 
      this.label62.AutoSize = true;
      this.label62.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label62.Location = new System.Drawing.Point(727, 561);
      this.label62.Name = "label62";
      this.label62.Size = new System.Drawing.Size(25, 13);
      this.label62.TabIndex = 135;
      this.label62.Text = "750";
      // 
      // label63
      // 
      this.label63.AutoSize = true;
      this.label63.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label63.Location = new System.Drawing.Point(633, 561);
      this.label63.Name = "label63";
      this.label63.Size = new System.Drawing.Size(25, 13);
      this.label63.TabIndex = 134;
      this.label63.Text = "500";
      // 
      // label64
      // 
      this.label64.AutoSize = true;
      this.label64.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label64.Location = new System.Drawing.Point(810, 561);
      this.label64.Name = "label64";
      this.label64.Size = new System.Drawing.Size(31, 13);
      this.label64.TabIndex = 133;
      this.label64.Text = "1000";
      // 
      // label65
      // 
      this.label65.AutoSize = true;
      this.label65.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label65.Location = new System.Drawing.Point(452, 561);
      this.label65.Name = "label65";
      this.label65.Size = new System.Drawing.Size(13, 13);
      this.label65.TabIndex = 132;
      this.label65.Text = "0";
      // 
      // lb_ROLL_DAMPER_MAX_VELOCITY
      // 
      this.lb_ROLL_DAMPER_MAX_VELOCITY.AutoSize = true;
      this.lb_ROLL_DAMPER_MAX_VELOCITY.Location = new System.Drawing.Point(595, 518);
      this.lb_ROLL_DAMPER_MAX_VELOCITY.Name = "lb_ROLL_DAMPER_MAX_VELOCITY";
      this.lb_ROLL_DAMPER_MAX_VELOCITY.Size = new System.Drawing.Size(107, 13);
      this.lb_ROLL_DAMPER_MAX_VELOCITY.TabIndex = 131;
      this.lb_ROLL_DAMPER_MAX_VELOCITY.Text = "Damper Max Velocity";
      // 
      // tb_ROLL_DAMPER_MAX_VELOCITY
      // 
      this.tb_ROLL_DAMPER_MAX_VELOCITY.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_DAMPER_MAX_VELOCITY.LargeChange = 10;
      this.tb_ROLL_DAMPER_MAX_VELOCITY.Location = new System.Drawing.Point(444, 531);
      this.tb_ROLL_DAMPER_MAX_VELOCITY.Maximum = 1000;
      this.tb_ROLL_DAMPER_MAX_VELOCITY.Name = "tb_ROLL_DAMPER_MAX_VELOCITY";
      this.tb_ROLL_DAMPER_MAX_VELOCITY.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_DAMPER_MAX_VELOCITY.TabIndex = 22;
      this.tb_ROLL_DAMPER_MAX_VELOCITY.TickFrequency = 25;
      this.tb_ROLL_DAMPER_MAX_VELOCITY.Scroll += new System.EventHandler(this.tb_ROLL_DAMPER_MAX_VELOCITY_Scroll);
      this.tb_ROLL_DAMPER_MAX_VELOCITY.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_INERTIA_MAX_ACCELERATION
      // 
      this.lb_ROLL_INERTIA_MAX_ACCELERATION.AutoSize = true;
      this.lb_ROLL_INERTIA_MAX_ACCELERATION.Location = new System.Drawing.Point(155, 518);
      this.lb_ROLL_INERTIA_MAX_ACCELERATION.Name = "lb_ROLL_INERTIA_MAX_ACCELERATION";
      this.lb_ROLL_INERTIA_MAX_ACCELERATION.Size = new System.Drawing.Size(121, 13);
      this.lb_ROLL_INERTIA_MAX_ACCELERATION.TabIndex = 129;
      this.lb_ROLL_INERTIA_MAX_ACCELERATION.Text = "Inertia Max Acceleration";
      // 
      // label68
      // 
      this.label68.AutoSize = true;
      this.label68.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label68.Location = new System.Drawing.Point(108, 561);
      this.label68.Name = "label68";
      this.label68.Size = new System.Drawing.Size(25, 13);
      this.label68.TabIndex = 128;
      this.label68.Text = "250";
      // 
      // label69
      // 
      this.label69.AutoSize = true;
      this.label69.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label69.Location = new System.Drawing.Point(294, 561);
      this.label69.Name = "label69";
      this.label69.Size = new System.Drawing.Size(25, 13);
      this.label69.TabIndex = 127;
      this.label69.Text = "750";
      // 
      // label70
      // 
      this.label70.AutoSize = true;
      this.label70.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label70.Location = new System.Drawing.Point(200, 561);
      this.label70.Name = "label70";
      this.label70.Size = new System.Drawing.Size(25, 13);
      this.label70.TabIndex = 126;
      this.label70.Text = "500";
      // 
      // label71
      // 
      this.label71.AutoSize = true;
      this.label71.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label71.Location = new System.Drawing.Point(381, 561);
      this.label71.Name = "label71";
      this.label71.Size = new System.Drawing.Size(31, 13);
      this.label71.TabIndex = 125;
      this.label71.Text = "1000";
      // 
      // label72
      // 
      this.label72.AutoSize = true;
      this.label72.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label72.Location = new System.Drawing.Point(20, 561);
      this.label72.Name = "label72";
      this.label72.Size = new System.Drawing.Size(13, 13);
      this.label72.TabIndex = 124;
      this.label72.Text = "0";
      // 
      // tb_ROLL_INERTIA_MAX_ACCELERATION
      // 
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.LargeChange = 10;
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.Location = new System.Drawing.Point(13, 531);
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.Maximum = 1000;
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.Name = "tb_ROLL_INERTIA_MAX_ACCELERATION";
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.TabIndex = 21;
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.TickFrequency = 25;
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.Scroll += new System.EventHandler(this.tb_ROLL_INERTIA_MAX_ACCELERATION_Scroll);
      this.tb_ROLL_INERTIA_MAX_ACCELERATION.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label73
      // 
      this.label73.AutoSize = true;
      this.label73.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label73.Location = new System.Drawing.Point(108, 502);
      this.label73.Name = "label73";
      this.label73.Size = new System.Drawing.Size(25, 13);
      this.label73.TabIndex = 122;
      this.label73.Text = "250";
      // 
      // label74
      // 
      this.label74.AutoSize = true;
      this.label74.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label74.Location = new System.Drawing.Point(295, 502);
      this.label74.Name = "label74";
      this.label74.Size = new System.Drawing.Size(25, 13);
      this.label74.TabIndex = 121;
      this.label74.Text = "750";
      // 
      // label75
      // 
      this.label75.AutoSize = true;
      this.label75.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label75.Location = new System.Drawing.Point(203, 502);
      this.label75.Name = "label75";
      this.label75.Size = new System.Drawing.Size(25, 13);
      this.label75.TabIndex = 120;
      this.label75.Text = "500";
      // 
      // label76
      // 
      this.label76.AutoSize = true;
      this.label76.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label76.Location = new System.Drawing.Point(379, 502);
      this.label76.Name = "label76";
      this.label76.Size = new System.Drawing.Size(31, 13);
      this.label76.TabIndex = 119;
      this.label76.Text = "1000";
      // 
      // label77
      // 
      this.label77.AutoSize = true;
      this.label77.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label77.Location = new System.Drawing.Point(21, 502);
      this.label77.Name = "label77";
      this.label77.Size = new System.Drawing.Size(13, 13);
      this.label77.TabIndex = 118;
      this.label77.Text = "0";
      // 
      // lb_ROLL_FRICTION_MAX_POSITION_CHANGE
      // 
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE.AutoSize = true;
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE.Location = new System.Drawing.Point(144, 457);
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE.Name = "lb_ROLL_FRICTION_MAX_POSITION_CHANGE";
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE.Size = new System.Drawing.Size(144, 13);
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE.TabIndex = 117;
      this.lb_ROLL_FRICTION_MAX_POSITION_CHANGE.Text = "Friction Max Position Change";
      // 
      // tb_ROLL_FRICTION_MAX_POSITION_CHANGE
      // 
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.LargeChange = 10;
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Location = new System.Drawing.Point(13, 470);
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Maximum = 1000;
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Name = "tb_ROLL_FRICTION_MAX_POSITION_CHANGE";
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.TabIndex = 20;
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.TickFrequency = 25;
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Scroll += new System.EventHandler(this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE_Scroll);
      this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_FRICTION_GAIN
      // 
      this.lb_ROLL_FRICTION_GAIN.AutoSize = true;
      this.lb_ROLL_FRICTION_GAIN.Location = new System.Drawing.Point(612, 389);
      this.lb_ROLL_FRICTION_GAIN.Name = "lb_ROLL_FRICTION_GAIN";
      this.lb_ROLL_FRICTION_GAIN.Size = new System.Drawing.Size(66, 13);
      this.lb_ROLL_FRICTION_GAIN.TabIndex = 115;
      this.lb_ROLL_FRICTION_GAIN.Text = "Friction Gain";
      // 
      // label80
      // 
      this.label80.AutoSize = true;
      this.label80.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label80.Location = new System.Drawing.Point(539, 434);
      this.label80.Name = "label80";
      this.label80.Size = new System.Drawing.Size(19, 13);
      this.label80.TabIndex = 114;
      this.label80.Text = "25";
      // 
      // label81
      // 
      this.label81.AutoSize = true;
      this.label81.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label81.Location = new System.Drawing.Point(729, 434);
      this.label81.Name = "label81";
      this.label81.Size = new System.Drawing.Size(19, 13);
      this.label81.TabIndex = 113;
      this.label81.Text = "75";
      // 
      // label82
      // 
      this.label82.AutoSize = true;
      this.label82.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label82.Location = new System.Drawing.Point(635, 434);
      this.label82.Name = "label82";
      this.label82.Size = new System.Drawing.Size(19, 13);
      this.label82.TabIndex = 112;
      this.label82.Text = "50";
      // 
      // label83
      // 
      this.label83.AutoSize = true;
      this.label83.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label83.Location = new System.Drawing.Point(819, 434);
      this.label83.Name = "label83";
      this.label83.Size = new System.Drawing.Size(25, 13);
      this.label83.TabIndex = 111;
      this.label83.Text = "100";
      // 
      // label84
      // 
      this.label84.AutoSize = true;
      this.label84.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label84.Location = new System.Drawing.Point(451, 434);
      this.label84.Name = "label84";
      this.label84.Size = new System.Drawing.Size(13, 13);
      this.label84.TabIndex = 110;
      this.label84.Text = "0";
      // 
      // tb_ROLL_FRICTION_GAIN
      // 
      this.tb_ROLL_FRICTION_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_FRICTION_GAIN.LargeChange = 10;
      this.tb_ROLL_FRICTION_GAIN.Location = new System.Drawing.Point(444, 402);
      this.tb_ROLL_FRICTION_GAIN.Maximum = 100;
      this.tb_ROLL_FRICTION_GAIN.Name = "tb_ROLL_FRICTION_GAIN";
      this.tb_ROLL_FRICTION_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_FRICTION_GAIN.TabIndex = 19;
      this.tb_ROLL_FRICTION_GAIN.TickFrequency = 5;
      this.tb_ROLL_FRICTION_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_FRICTION_GAIN_Scroll);
      this.tb_ROLL_FRICTION_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_INERTIA_GAIN
      // 
      this.lb_ROLL_INERTIA_GAIN.AutoSize = true;
      this.lb_ROLL_INERTIA_GAIN.Location = new System.Drawing.Point(181, 388);
      this.lb_ROLL_INERTIA_GAIN.Name = "lb_ROLL_INERTIA_GAIN";
      this.lb_ROLL_INERTIA_GAIN.Size = new System.Drawing.Size(61, 13);
      this.lb_ROLL_INERTIA_GAIN.TabIndex = 101;
      this.lb_ROLL_INERTIA_GAIN.Text = "Inertia Gain";
      // 
      // label92
      // 
      this.label92.AutoSize = true;
      this.label92.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label92.Location = new System.Drawing.Point(108, 434);
      this.label92.Name = "label92";
      this.label92.Size = new System.Drawing.Size(19, 13);
      this.label92.TabIndex = 100;
      this.label92.Text = "25";
      // 
      // label93
      // 
      this.label93.AutoSize = true;
      this.label93.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label93.Location = new System.Drawing.Point(299, 434);
      this.label93.Name = "label93";
      this.label93.Size = new System.Drawing.Size(19, 13);
      this.label93.TabIndex = 99;
      this.label93.Text = "75";
      // 
      // label94
      // 
      this.label94.AutoSize = true;
      this.label94.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label94.Location = new System.Drawing.Point(204, 434);
      this.label94.Name = "label94";
      this.label94.Size = new System.Drawing.Size(19, 13);
      this.label94.TabIndex = 98;
      this.label94.Text = "50";
      // 
      // label95
      // 
      this.label95.AutoSize = true;
      this.label95.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label95.Location = new System.Drawing.Point(388, 434);
      this.label95.Name = "label95";
      this.label95.Size = new System.Drawing.Size(25, 13);
      this.label95.TabIndex = 97;
      this.label95.Text = "100";
      // 
      // label96
      // 
      this.label96.AutoSize = true;
      this.label96.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label96.Location = new System.Drawing.Point(20, 434);
      this.label96.Name = "label96";
      this.label96.Size = new System.Drawing.Size(13, 13);
      this.label96.TabIndex = 96;
      this.label96.Text = "0";
      // 
      // tb_ROLL_INERTIA_GAIN
      // 
      this.tb_ROLL_INERTIA_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_INERTIA_GAIN.LargeChange = 10;
      this.tb_ROLL_INERTIA_GAIN.Location = new System.Drawing.Point(13, 402);
      this.tb_ROLL_INERTIA_GAIN.Maximum = 100;
      this.tb_ROLL_INERTIA_GAIN.Name = "tb_ROLL_INERTIA_GAIN";
      this.tb_ROLL_INERTIA_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_INERTIA_GAIN.TabIndex = 17;
      this.tb_ROLL_INERTIA_GAIN.TickFrequency = 5;
      this.tb_ROLL_INERTIA_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_INERTIA_GAIN_Scroll);
      this.tb_ROLL_INERTIA_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label97
      // 
      this.label97.AutoSize = true;
      this.label97.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label97.Location = new System.Drawing.Point(540, 370);
      this.label97.Name = "label97";
      this.label97.Size = new System.Drawing.Size(19, 13);
      this.label97.TabIndex = 94;
      this.label97.Text = "25";
      // 
      // label98
      // 
      this.label98.AutoSize = true;
      this.label98.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label98.Location = new System.Drawing.Point(731, 370);
      this.label98.Name = "label98";
      this.label98.Size = new System.Drawing.Size(19, 13);
      this.label98.TabIndex = 93;
      this.label98.Text = "75";
      // 
      // label99
      // 
      this.label99.AutoSize = true;
      this.label99.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label99.Location = new System.Drawing.Point(636, 370);
      this.label99.Name = "label99";
      this.label99.Size = new System.Drawing.Size(19, 13);
      this.label99.TabIndex = 92;
      this.label99.Text = "50";
      // 
      // label100
      // 
      this.label100.AutoSize = true;
      this.label100.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label100.Location = new System.Drawing.Point(816, 370);
      this.label100.Name = "label100";
      this.label100.Size = new System.Drawing.Size(25, 13);
      this.label100.TabIndex = 91;
      this.label100.Text = "100";
      // 
      // label101
      // 
      this.label101.AutoSize = true;
      this.label101.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label101.Location = new System.Drawing.Point(452, 370);
      this.label101.Name = "label101";
      this.label101.Size = new System.Drawing.Size(13, 13);
      this.label101.TabIndex = 90;
      this.label101.Text = "0";
      // 
      // lb_ROLL_DAMPER_GAIN
      // 
      this.lb_ROLL_DAMPER_GAIN.AutoSize = true;
      this.lb_ROLL_DAMPER_GAIN.Location = new System.Drawing.Point(613, 327);
      this.lb_ROLL_DAMPER_GAIN.Name = "lb_ROLL_DAMPER_GAIN";
      this.lb_ROLL_DAMPER_GAIN.Size = new System.Drawing.Size(69, 13);
      this.lb_ROLL_DAMPER_GAIN.TabIndex = 89;
      this.lb_ROLL_DAMPER_GAIN.Text = "Damper Gain";
      // 
      // tb_ROLL_DAMPER_GAIN
      // 
      this.tb_ROLL_DAMPER_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_DAMPER_GAIN.LargeChange = 10;
      this.tb_ROLL_DAMPER_GAIN.Location = new System.Drawing.Point(444, 340);
      this.tb_ROLL_DAMPER_GAIN.Maximum = 100;
      this.tb_ROLL_DAMPER_GAIN.Name = "tb_ROLL_DAMPER_GAIN";
      this.tb_ROLL_DAMPER_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_DAMPER_GAIN.TabIndex = 16;
      this.tb_ROLL_DAMPER_GAIN.TickFrequency = 5;
      this.tb_ROLL_DAMPER_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_DAMPER_GAIN_Scroll);
      this.tb_ROLL_DAMPER_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_SPRING_GAIN
      // 
      this.lb_ROLL_SPRING_GAIN.AutoSize = true;
      this.lb_ROLL_SPRING_GAIN.Location = new System.Drawing.Point(180, 327);
      this.lb_ROLL_SPRING_GAIN.Name = "lb_ROLL_SPRING_GAIN";
      this.lb_ROLL_SPRING_GAIN.Size = new System.Drawing.Size(62, 13);
      this.lb_ROLL_SPRING_GAIN.TabIndex = 87;
      this.lb_ROLL_SPRING_GAIN.Text = "Spring Gain";
      // 
      // label104
      // 
      this.label104.AutoSize = true;
      this.label104.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label104.Location = new System.Drawing.Point(108, 370);
      this.label104.Name = "label104";
      this.label104.Size = new System.Drawing.Size(19, 13);
      this.label104.TabIndex = 86;
      this.label104.Text = "25";
      // 
      // label105
      // 
      this.label105.AutoSize = true;
      this.label105.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label105.Location = new System.Drawing.Point(299, 370);
      this.label105.Name = "label105";
      this.label105.Size = new System.Drawing.Size(19, 13);
      this.label105.TabIndex = 85;
      this.label105.Text = "75";
      // 
      // label106
      // 
      this.label106.AutoSize = true;
      this.label106.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label106.Location = new System.Drawing.Point(204, 370);
      this.label106.Name = "label106";
      this.label106.Size = new System.Drawing.Size(19, 13);
      this.label106.TabIndex = 84;
      this.label106.Text = "50";
      // 
      // label107
      // 
      this.label107.AutoSize = true;
      this.label107.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label107.Location = new System.Drawing.Point(388, 370);
      this.label107.Name = "label107";
      this.label107.Size = new System.Drawing.Size(25, 13);
      this.label107.TabIndex = 83;
      this.label107.Text = "100";
      // 
      // label108
      // 
      this.label108.AutoSize = true;
      this.label108.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label108.Location = new System.Drawing.Point(20, 370);
      this.label108.Name = "label108";
      this.label108.Size = new System.Drawing.Size(13, 13);
      this.label108.TabIndex = 82;
      this.label108.Text = "0";
      // 
      // tb_ROLL_SPRING_GAIN
      // 
      this.tb_ROLL_SPRING_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_SPRING_GAIN.LargeChange = 10;
      this.tb_ROLL_SPRING_GAIN.Location = new System.Drawing.Point(13, 340);
      this.tb_ROLL_SPRING_GAIN.Maximum = 100;
      this.tb_ROLL_SPRING_GAIN.Name = "tb_ROLL_SPRING_GAIN";
      this.tb_ROLL_SPRING_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_SPRING_GAIN.TabIndex = 15;
      this.tb_ROLL_SPRING_GAIN.TickFrequency = 5;
      this.tb_ROLL_SPRING_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_SPRING_GAIN_Scroll);
      this.tb_ROLL_SPRING_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label37
      // 
      this.label37.AutoSize = true;
      this.label37.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label37.Location = new System.Drawing.Point(540, 306);
      this.label37.Name = "label37";
      this.label37.Size = new System.Drawing.Size(19, 13);
      this.label37.TabIndex = 80;
      this.label37.Text = "25";
      // 
      // label38
      // 
      this.label38.AutoSize = true;
      this.label38.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label38.Location = new System.Drawing.Point(731, 306);
      this.label38.Name = "label38";
      this.label38.Size = new System.Drawing.Size(19, 13);
      this.label38.TabIndex = 79;
      this.label38.Text = "75";
      // 
      // label39
      // 
      this.label39.AutoSize = true;
      this.label39.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label39.Location = new System.Drawing.Point(636, 306);
      this.label39.Name = "label39";
      this.label39.Size = new System.Drawing.Size(19, 13);
      this.label39.TabIndex = 78;
      this.label39.Text = "50";
      // 
      // label40
      // 
      this.label40.AutoSize = true;
      this.label40.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label40.Location = new System.Drawing.Point(816, 306);
      this.label40.Name = "label40";
      this.label40.Size = new System.Drawing.Size(25, 13);
      this.label40.TabIndex = 77;
      this.label40.Text = "100";
      // 
      // label41
      // 
      this.label41.AutoSize = true;
      this.label41.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label41.Location = new System.Drawing.Point(452, 306);
      this.label41.Name = "label41";
      this.label41.Size = new System.Drawing.Size(13, 13);
      this.label41.TabIndex = 76;
      this.label41.Text = "0";
      // 
      // lb_ROLL_SAWTOOTH_UP_GAIN
      // 
      this.lb_ROLL_SAWTOOTH_UP_GAIN.AutoSize = true;
      this.lb_ROLL_SAWTOOTH_UP_GAIN.Location = new System.Drawing.Point(607, 260);
      this.lb_ROLL_SAWTOOTH_UP_GAIN.Name = "lb_ROLL_SAWTOOTH_UP_GAIN";
      this.lb_ROLL_SAWTOOTH_UP_GAIN.Size = new System.Drawing.Size(94, 13);
      this.lb_ROLL_SAWTOOTH_UP_GAIN.TabIndex = 75;
      this.lb_ROLL_SAWTOOTH_UP_GAIN.Text = "Sawtooth Up Gain";
      // 
      // tb_ROLL_SAWTOOTH_UP_GAIN
      // 
      this.tb_ROLL_SAWTOOTH_UP_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_SAWTOOTH_UP_GAIN.LargeChange = 10;
      this.tb_ROLL_SAWTOOTH_UP_GAIN.Location = new System.Drawing.Point(444, 274);
      this.tb_ROLL_SAWTOOTH_UP_GAIN.Maximum = 100;
      this.tb_ROLL_SAWTOOTH_UP_GAIN.Name = "tb_ROLL_SAWTOOTH_UP_GAIN";
      this.tb_ROLL_SAWTOOTH_UP_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_SAWTOOTH_UP_GAIN.TabIndex = 14;
      this.tb_ROLL_SAWTOOTH_UP_GAIN.TickFrequency = 5;
      this.tb_ROLL_SAWTOOTH_UP_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_SAWTOOTH_UP_GAIN_Scroll);
      this.tb_ROLL_SAWTOOTH_UP_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_SAWTOOT_DOWN_GAIN
      // 
      this.lb_ROLL_SAWTOOT_DOWN_GAIN.AutoSize = true;
      this.lb_ROLL_SAWTOOT_DOWN_GAIN.Location = new System.Drawing.Point(168, 260);
      this.lb_ROLL_SAWTOOT_DOWN_GAIN.Name = "lb_ROLL_SAWTOOT_DOWN_GAIN";
      this.lb_ROLL_SAWTOOT_DOWN_GAIN.Size = new System.Drawing.Size(108, 13);
      this.lb_ROLL_SAWTOOT_DOWN_GAIN.TabIndex = 73;
      this.lb_ROLL_SAWTOOT_DOWN_GAIN.Text = "Sawtooth Down Gain";
      // 
      // label44
      // 
      this.label44.AutoSize = true;
      this.label44.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label44.Location = new System.Drawing.Point(108, 306);
      this.label44.Name = "label44";
      this.label44.Size = new System.Drawing.Size(19, 13);
      this.label44.TabIndex = 72;
      this.label44.Text = "25";
      // 
      // label45
      // 
      this.label45.AutoSize = true;
      this.label45.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label45.Location = new System.Drawing.Point(299, 306);
      this.label45.Name = "label45";
      this.label45.Size = new System.Drawing.Size(19, 13);
      this.label45.TabIndex = 71;
      this.label45.Text = "75";
      // 
      // label46
      // 
      this.label46.AutoSize = true;
      this.label46.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label46.Location = new System.Drawing.Point(204, 306);
      this.label46.Name = "label46";
      this.label46.Size = new System.Drawing.Size(19, 13);
      this.label46.TabIndex = 70;
      this.label46.Text = "50";
      // 
      // label47
      // 
      this.label47.AutoSize = true;
      this.label47.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label47.Location = new System.Drawing.Point(388, 306);
      this.label47.Name = "label47";
      this.label47.Size = new System.Drawing.Size(25, 13);
      this.label47.TabIndex = 69;
      this.label47.Text = "100";
      // 
      // label48
      // 
      this.label48.AutoSize = true;
      this.label48.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label48.Location = new System.Drawing.Point(20, 306);
      this.label48.Name = "label48";
      this.label48.Size = new System.Drawing.Size(13, 13);
      this.label48.TabIndex = 68;
      this.label48.Text = "0";
      // 
      // tb_ROLL_SAWTOOT_DOWN_GAIN
      // 
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.LargeChange = 10;
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.Location = new System.Drawing.Point(13, 274);
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.Maximum = 100;
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.Name = "tb_ROLL_SAWTOOT_DOWN_GAIN";
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.TabIndex = 13;
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.TickFrequency = 5;
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_SAWTOOT_DOWN_GAIN_Scroll);
      this.tb_ROLL_SAWTOOT_DOWN_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label49
      // 
      this.label49.AutoSize = true;
      this.label49.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label49.Location = new System.Drawing.Point(540, 244);
      this.label49.Name = "label49";
      this.label49.Size = new System.Drawing.Size(19, 13);
      this.label49.TabIndex = 66;
      this.label49.Text = "25";
      // 
      // label50
      // 
      this.label50.AutoSize = true;
      this.label50.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label50.Location = new System.Drawing.Point(731, 244);
      this.label50.Name = "label50";
      this.label50.Size = new System.Drawing.Size(19, 13);
      this.label50.TabIndex = 65;
      this.label50.Text = "75";
      // 
      // label51
      // 
      this.label51.AutoSize = true;
      this.label51.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label51.Location = new System.Drawing.Point(636, 244);
      this.label51.Name = "label51";
      this.label51.Size = new System.Drawing.Size(19, 13);
      this.label51.TabIndex = 64;
      this.label51.Text = "50";
      // 
      // label52
      // 
      this.label52.AutoSize = true;
      this.label52.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label52.Location = new System.Drawing.Point(816, 244);
      this.label52.Name = "label52";
      this.label52.Size = new System.Drawing.Size(25, 13);
      this.label52.TabIndex = 63;
      this.label52.Text = "100";
      // 
      // label53
      // 
      this.label53.AutoSize = true;
      this.label53.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label53.Location = new System.Drawing.Point(452, 244);
      this.label53.Name = "label53";
      this.label53.Size = new System.Drawing.Size(13, 13);
      this.label53.TabIndex = 62;
      this.label53.Text = "0";
      // 
      // lb_ROLL_TRIANGLE_GAIN
      // 
      this.lb_ROLL_TRIANGLE_GAIN.AutoSize = true;
      this.lb_ROLL_TRIANGLE_GAIN.Location = new System.Drawing.Point(613, 199);
      this.lb_ROLL_TRIANGLE_GAIN.Name = "lb_ROLL_TRIANGLE_GAIN";
      this.lb_ROLL_TRIANGLE_GAIN.Size = new System.Drawing.Size(70, 13);
      this.lb_ROLL_TRIANGLE_GAIN.TabIndex = 61;
      this.lb_ROLL_TRIANGLE_GAIN.Text = "Triangle Gain";
      // 
      // tb_ROLL_TRIANGLE_GAIN
      // 
      this.tb_ROLL_TRIANGLE_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_TRIANGLE_GAIN.LargeChange = 10;
      this.tb_ROLL_TRIANGLE_GAIN.Location = new System.Drawing.Point(444, 212);
      this.tb_ROLL_TRIANGLE_GAIN.Maximum = 100;
      this.tb_ROLL_TRIANGLE_GAIN.Name = "tb_ROLL_TRIANGLE_GAIN";
      this.tb_ROLL_TRIANGLE_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_TRIANGLE_GAIN.TabIndex = 12;
      this.tb_ROLL_TRIANGLE_GAIN.TickFrequency = 5;
      this.tb_ROLL_TRIANGLE_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_TRIANGLE_GAIN_Scroll);
      this.tb_ROLL_TRIANGLE_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_SIN_GAIN
      // 
      this.lb_ROLL_SIN_GAIN.AutoSize = true;
      this.lb_ROLL_SIN_GAIN.Location = new System.Drawing.Point(189, 199);
      this.lb_ROLL_SIN_GAIN.Name = "lb_ROLL_SIN_GAIN";
      this.lb_ROLL_SIN_GAIN.Size = new System.Drawing.Size(53, 13);
      this.lb_ROLL_SIN_GAIN.TabIndex = 59;
      this.lb_ROLL_SIN_GAIN.Text = "Sine Gain";
      // 
      // label56
      // 
      this.label56.AutoSize = true;
      this.label56.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label56.Location = new System.Drawing.Point(108, 244);
      this.label56.Name = "label56";
      this.label56.Size = new System.Drawing.Size(19, 13);
      this.label56.TabIndex = 58;
      this.label56.Text = "25";
      // 
      // label57
      // 
      this.label57.AutoSize = true;
      this.label57.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label57.Location = new System.Drawing.Point(299, 244);
      this.label57.Name = "label57";
      this.label57.Size = new System.Drawing.Size(19, 13);
      this.label57.TabIndex = 57;
      this.label57.Text = "75";
      // 
      // label58
      // 
      this.label58.AutoSize = true;
      this.label58.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label58.Location = new System.Drawing.Point(204, 244);
      this.label58.Name = "label58";
      this.label58.Size = new System.Drawing.Size(19, 13);
      this.label58.TabIndex = 56;
      this.label58.Text = "50";
      // 
      // label59
      // 
      this.label59.AutoSize = true;
      this.label59.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label59.Location = new System.Drawing.Point(388, 244);
      this.label59.Name = "label59";
      this.label59.Size = new System.Drawing.Size(25, 13);
      this.label59.TabIndex = 55;
      this.label59.Text = "100";
      // 
      // label60
      // 
      this.label60.AutoSize = true;
      this.label60.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label60.Location = new System.Drawing.Point(20, 244);
      this.label60.Name = "label60";
      this.label60.Size = new System.Drawing.Size(13, 13);
      this.label60.TabIndex = 54;
      this.label60.Text = "0";
      // 
      // tb_ROLL_SIN_GAIN
      // 
      this.tb_ROLL_SIN_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_SIN_GAIN.LargeChange = 10;
      this.tb_ROLL_SIN_GAIN.Location = new System.Drawing.Point(13, 212);
      this.tb_ROLL_SIN_GAIN.Maximum = 100;
      this.tb_ROLL_SIN_GAIN.Name = "tb_ROLL_SIN_GAIN";
      this.tb_ROLL_SIN_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_SIN_GAIN.TabIndex = 11;
      this.tb_ROLL_SIN_GAIN.TickFrequency = 5;
      this.tb_ROLL_SIN_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_SIN_GAIN_Scroll);
      this.tb_ROLL_SIN_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label16.Location = new System.Drawing.Point(540, 175);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(19, 13);
      this.label16.TabIndex = 52;
      this.label16.Text = "25";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label21.Location = new System.Drawing.Point(731, 175);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(19, 13);
      this.label21.TabIndex = 51;
      this.label21.Text = "75";
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label22.Location = new System.Drawing.Point(636, 175);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(19, 13);
      this.label22.TabIndex = 50;
      this.label22.Text = "50";
      // 
      // label23
      // 
      this.label23.AutoSize = true;
      this.label23.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label23.Location = new System.Drawing.Point(816, 175);
      this.label23.Name = "label23";
      this.label23.Size = new System.Drawing.Size(25, 13);
      this.label23.TabIndex = 49;
      this.label23.Text = "100";
      // 
      // label24
      // 
      this.label24.AutoSize = true;
      this.label24.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label24.Location = new System.Drawing.Point(452, 175);
      this.label24.Name = "label24";
      this.label24.Size = new System.Drawing.Size(13, 13);
      this.label24.TabIndex = 48;
      this.label24.Text = "0";
      // 
      // lb_ROLL_SQUARE_GAIN
      // 
      this.lb_ROLL_SQUARE_GAIN.AutoSize = true;
      this.lb_ROLL_SQUARE_GAIN.Location = new System.Drawing.Point(616, 132);
      this.lb_ROLL_SQUARE_GAIN.Name = "lb_ROLL_SQUARE_GAIN";
      this.lb_ROLL_SQUARE_GAIN.Size = new System.Drawing.Size(66, 13);
      this.lb_ROLL_SQUARE_GAIN.TabIndex = 47;
      this.lb_ROLL_SQUARE_GAIN.Text = "Square Gain";
      // 
      // tb_ROLL_SQUARE_GAIN
      // 
      this.tb_ROLL_SQUARE_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_SQUARE_GAIN.LargeChange = 10;
      this.tb_ROLL_SQUARE_GAIN.Location = new System.Drawing.Point(444, 145);
      this.tb_ROLL_SQUARE_GAIN.Maximum = 100;
      this.tb_ROLL_SQUARE_GAIN.Name = "tb_ROLL_SQUARE_GAIN";
      this.tb_ROLL_SQUARE_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_SQUARE_GAIN.TabIndex = 10;
      this.tb_ROLL_SQUARE_GAIN.TickFrequency = 5;
      this.tb_ROLL_SQUARE_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_SQUARE_GAIN_Scroll);
      this.tb_ROLL_SQUARE_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_RAMP_GAIN
      // 
      this.lb_ROLL_RAMP_GAIN.AutoSize = true;
      this.lb_ROLL_RAMP_GAIN.Location = new System.Drawing.Point(187, 132);
      this.lb_ROLL_RAMP_GAIN.Name = "lb_ROLL_RAMP_GAIN";
      this.lb_ROLL_RAMP_GAIN.Size = new System.Drawing.Size(60, 13);
      this.lb_ROLL_RAMP_GAIN.TabIndex = 45;
      this.lb_ROLL_RAMP_GAIN.Text = "Ramp Gain";
      // 
      // label32
      // 
      this.label32.AutoSize = true;
      this.label32.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label32.Location = new System.Drawing.Point(108, 175);
      this.label32.Name = "label32";
      this.label32.Size = new System.Drawing.Size(19, 13);
      this.label32.TabIndex = 44;
      this.label32.Text = "25";
      // 
      // label33
      // 
      this.label33.AutoSize = true;
      this.label33.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label33.Location = new System.Drawing.Point(299, 175);
      this.label33.Name = "label33";
      this.label33.Size = new System.Drawing.Size(19, 13);
      this.label33.TabIndex = 43;
      this.label33.Text = "75";
      // 
      // label34
      // 
      this.label34.AutoSize = true;
      this.label34.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label34.Location = new System.Drawing.Point(204, 175);
      this.label34.Name = "label34";
      this.label34.Size = new System.Drawing.Size(19, 13);
      this.label34.TabIndex = 42;
      this.label34.Text = "50";
      // 
      // label35
      // 
      this.label35.AutoSize = true;
      this.label35.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label35.Location = new System.Drawing.Point(388, 175);
      this.label35.Name = "label35";
      this.label35.Size = new System.Drawing.Size(25, 13);
      this.label35.TabIndex = 41;
      this.label35.Text = "100";
      // 
      // label36
      // 
      this.label36.AutoSize = true;
      this.label36.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label36.Location = new System.Drawing.Point(20, 175);
      this.label36.Name = "label36";
      this.label36.Size = new System.Drawing.Size(13, 13);
      this.label36.TabIndex = 40;
      this.label36.Text = "0";
      // 
      // tb_ROLL_RAMP_GAIN
      // 
      this.tb_ROLL_RAMP_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_RAMP_GAIN.LargeChange = 10;
      this.tb_ROLL_RAMP_GAIN.Location = new System.Drawing.Point(13, 145);
      this.tb_ROLL_RAMP_GAIN.Maximum = 100;
      this.tb_ROLL_RAMP_GAIN.Name = "tb_ROLL_RAMP_GAIN";
      this.tb_ROLL_RAMP_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_RAMP_GAIN.TabIndex = 9;
      this.tb_ROLL_RAMP_GAIN.TickFrequency = 5;
      this.tb_ROLL_RAMP_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_RAMP_GAIN_Scroll);
      this.tb_ROLL_RAMP_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label25
      // 
      this.label25.AutoSize = true;
      this.label25.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label25.Location = new System.Drawing.Point(540, 115);
      this.label25.Name = "label25";
      this.label25.Size = new System.Drawing.Size(19, 13);
      this.label25.TabIndex = 38;
      this.label25.Text = "25";
      // 
      // label26
      // 
      this.label26.AutoSize = true;
      this.label26.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label26.Location = new System.Drawing.Point(731, 115);
      this.label26.Name = "label26";
      this.label26.Size = new System.Drawing.Size(19, 13);
      this.label26.TabIndex = 37;
      this.label26.Text = "75";
      // 
      // label27
      // 
      this.label27.AutoSize = true;
      this.label27.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label27.Location = new System.Drawing.Point(636, 115);
      this.label27.Name = "label27";
      this.label27.Size = new System.Drawing.Size(19, 13);
      this.label27.TabIndex = 36;
      this.label27.Text = "50";
      // 
      // label28
      // 
      this.label28.AutoSize = true;
      this.label28.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label28.Location = new System.Drawing.Point(816, 115);
      this.label28.Name = "label28";
      this.label28.Size = new System.Drawing.Size(25, 13);
      this.label28.TabIndex = 35;
      this.label28.Text = "100";
      // 
      // label29
      // 
      this.label29.AutoSize = true;
      this.label29.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label29.Location = new System.Drawing.Point(452, 115);
      this.label29.Name = "label29";
      this.label29.Size = new System.Drawing.Size(13, 13);
      this.label29.TabIndex = 34;
      this.label29.Text = "0";
      // 
      // lb_ROLL_CONSTANT_GAIN
      // 
      this.lb_ROLL_CONSTANT_GAIN.AutoSize = true;
      this.lb_ROLL_CONSTANT_GAIN.Location = new System.Drawing.Point(607, 69);
      this.lb_ROLL_CONSTANT_GAIN.Name = "lb_ROLL_CONSTANT_GAIN";
      this.lb_ROLL_CONSTANT_GAIN.Size = new System.Drawing.Size(74, 13);
      this.lb_ROLL_CONSTANT_GAIN.TabIndex = 33;
      this.lb_ROLL_CONSTANT_GAIN.Text = "Constant Gain";
      // 
      // tb_ROLL_CONSTANT_GAIN
      // 
      this.tb_ROLL_CONSTANT_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_CONSTANT_GAIN.LargeChange = 10;
      this.tb_ROLL_CONSTANT_GAIN.Location = new System.Drawing.Point(444, 83);
      this.tb_ROLL_CONSTANT_GAIN.Maximum = 100;
      this.tb_ROLL_CONSTANT_GAIN.Name = "tb_ROLL_CONSTANT_GAIN";
      this.tb_ROLL_CONSTANT_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_CONSTANT_GAIN.TabIndex = 8;
      this.tb_ROLL_CONSTANT_GAIN.TickFrequency = 5;
      this.tb_ROLL_CONSTANT_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_CONSTANT_GAIN_Scroll);
      this.tb_ROLL_CONSTANT_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_ROLL_TOTAL_GAIN
      // 
      this.lb_ROLL_TOTAL_GAIN.AutoSize = true;
      this.lb_ROLL_TOTAL_GAIN.Location = new System.Drawing.Point(187, 69);
      this.lb_ROLL_TOTAL_GAIN.Name = "lb_ROLL_TOTAL_GAIN";
      this.lb_ROLL_TOTAL_GAIN.Size = new System.Drawing.Size(56, 13);
      this.lb_ROLL_TOTAL_GAIN.TabIndex = 31;
      this.lb_ROLL_TOTAL_GAIN.Text = "Total Gain";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label20.Location = new System.Drawing.Point(108, 115);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(19, 13);
      this.label20.TabIndex = 30;
      this.label20.Text = "25";
      // 
      // label18
      // 
      this.label18.AutoSize = true;
      this.label18.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label18.Location = new System.Drawing.Point(299, 115);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(19, 13);
      this.label18.TabIndex = 29;
      this.label18.Text = "75";
      // 
      // label17
      // 
      this.label17.AutoSize = true;
      this.label17.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label17.Location = new System.Drawing.Point(204, 115);
      this.label17.Name = "label17";
      this.label17.Size = new System.Drawing.Size(19, 13);
      this.label17.TabIndex = 28;
      this.label17.Text = "50";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label15.Location = new System.Drawing.Point(388, 115);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(25, 13);
      this.label15.TabIndex = 27;
      this.label15.Text = "100";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label11.Location = new System.Drawing.Point(20, 115);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(13, 13);
      this.label11.TabIndex = 26;
      this.label11.Text = "0";
      // 
      // tb_ROLL_TOTAL_GAIN
      // 
      this.tb_ROLL_TOTAL_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_TOTAL_GAIN.LargeChange = 10;
      this.tb_ROLL_TOTAL_GAIN.Location = new System.Drawing.Point(13, 83);
      this.tb_ROLL_TOTAL_GAIN.Maximum = 100;
      this.tb_ROLL_TOTAL_GAIN.Name = "tb_ROLL_TOTAL_GAIN";
      this.tb_ROLL_TOTAL_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_ROLL_TOTAL_GAIN.TabIndex = 7;
      this.tb_ROLL_TOTAL_GAIN.TickFrequency = 5;
      this.tb_ROLL_TOTAL_GAIN.Scroll += new System.EventHandler(this.tb_ROLL_TOTAL_GAIN_Scroll);
      this.tb_ROLL_TOTAL_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // tb_ROLL_PWM_MAX
      // 
      this.tb_ROLL_PWM_MAX.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_ROLL_PWM_MAX.LargeChange = 10;
      this.tb_ROLL_PWM_MAX.Location = new System.Drawing.Point(585, 21);
      this.tb_ROLL_PWM_MAX.Maximum = 255;
      this.tb_ROLL_PWM_MAX.Name = "tb_ROLL_PWM_MAX";
      this.tb_ROLL_PWM_MAX.Size = new System.Drawing.Size(250, 45);
      this.tb_ROLL_PWM_MAX.TabIndex = 6;
      this.tb_ROLL_PWM_MAX.TickFrequency = 15;
      this.tb_ROLL_PWM_MAX.Scroll += new System.EventHandler(this.tb_ROLL_PWM_MAX_Scroll);
      this.tb_ROLL_PWM_MAX.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // tabPageMainSettingsPitch
      // 
      this.tabPageMainSettingsPitch.BackColor = System.Drawing.Color.Gainsboro;
      this.tabPageMainSettingsPitch.Controls.Add(this.label119);
      this.tabPageMainSettingsPitch.Controls.Add(this.label120);
      this.tabPageMainSettingsPitch.Controls.Add(this.label121);
      this.tabPageMainSettingsPitch.Controls.Add(this.label122);
      this.tabPageMainSettingsPitch.Controls.Add(this.label123);
      this.tabPageMainSettingsPitch.Controls.Add(this.label124);
      this.tabPageMainSettingsPitch.Controls.Add(this.label125);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_PWM_MAX);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_PWM_MIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_PWM_MIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_FORCE_MAX);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_FORCE_MAX);
      this.tabPageMainSettingsPitch.Controls.Add(this.label129);
      this.tabPageMainSettingsPitch.Controls.Add(this.label130);
      this.tabPageMainSettingsPitch.Controls.Add(this.label131);
      this.tabPageMainSettingsPitch.Controls.Add(this.label132);
      this.tabPageMainSettingsPitch.Controls.Add(this.label133);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_DAMPER_MAX_VELOCITY);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_DAMPER_MAX_VELOCITY);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_INERTIA_MAX_ACCELERATION);
      this.tabPageMainSettingsPitch.Controls.Add(this.label136);
      this.tabPageMainSettingsPitch.Controls.Add(this.label137);
      this.tabPageMainSettingsPitch.Controls.Add(this.label138);
      this.tabPageMainSettingsPitch.Controls.Add(this.label139);
      this.tabPageMainSettingsPitch.Controls.Add(this.label140);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_INERTIA_MAX_ACCELERATION);
      this.tabPageMainSettingsPitch.Controls.Add(this.label141);
      this.tabPageMainSettingsPitch.Controls.Add(this.label142);
      this.tabPageMainSettingsPitch.Controls.Add(this.label143);
      this.tabPageMainSettingsPitch.Controls.Add(this.label144);
      this.tabPageMainSettingsPitch.Controls.Add(this.label145);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_FRICTION_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label148);
      this.tabPageMainSettingsPitch.Controls.Add(this.label149);
      this.tabPageMainSettingsPitch.Controls.Add(this.label150);
      this.tabPageMainSettingsPitch.Controls.Add(this.label151);
      this.tabPageMainSettingsPitch.Controls.Add(this.label152);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_FRICTION_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_INERTIA_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label160);
      this.tabPageMainSettingsPitch.Controls.Add(this.label161);
      this.tabPageMainSettingsPitch.Controls.Add(this.label162);
      this.tabPageMainSettingsPitch.Controls.Add(this.label163);
      this.tabPageMainSettingsPitch.Controls.Add(this.label164);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_INERTIA_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label165);
      this.tabPageMainSettingsPitch.Controls.Add(this.label166);
      this.tabPageMainSettingsPitch.Controls.Add(this.label167);
      this.tabPageMainSettingsPitch.Controls.Add(this.label168);
      this.tabPageMainSettingsPitch.Controls.Add(this.label169);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_DAMPER_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_DAMPER_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_SPRING_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label172);
      this.tabPageMainSettingsPitch.Controls.Add(this.label173);
      this.tabPageMainSettingsPitch.Controls.Add(this.label174);
      this.tabPageMainSettingsPitch.Controls.Add(this.label175);
      this.tabPageMainSettingsPitch.Controls.Add(this.label176);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_SPRING_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label177);
      this.tabPageMainSettingsPitch.Controls.Add(this.label178);
      this.tabPageMainSettingsPitch.Controls.Add(this.label179);
      this.tabPageMainSettingsPitch.Controls.Add(this.label180);
      this.tabPageMainSettingsPitch.Controls.Add(this.label181);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_SAWTOOTH_UP_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_SAWTOOTH_UP_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_SAWTOOT_DOWN_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label184);
      this.tabPageMainSettingsPitch.Controls.Add(this.label185);
      this.tabPageMainSettingsPitch.Controls.Add(this.label186);
      this.tabPageMainSettingsPitch.Controls.Add(this.label187);
      this.tabPageMainSettingsPitch.Controls.Add(this.label188);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_SAWTOOT_DOWN_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label189);
      this.tabPageMainSettingsPitch.Controls.Add(this.label190);
      this.tabPageMainSettingsPitch.Controls.Add(this.label191);
      this.tabPageMainSettingsPitch.Controls.Add(this.label192);
      this.tabPageMainSettingsPitch.Controls.Add(this.label193);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_TRIANGLE_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_TRIANGLE_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_SIN_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label196);
      this.tabPageMainSettingsPitch.Controls.Add(this.label197);
      this.tabPageMainSettingsPitch.Controls.Add(this.label198);
      this.tabPageMainSettingsPitch.Controls.Add(this.label199);
      this.tabPageMainSettingsPitch.Controls.Add(this.label200);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_SIN_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label201);
      this.tabPageMainSettingsPitch.Controls.Add(this.label202);
      this.tabPageMainSettingsPitch.Controls.Add(this.label203);
      this.tabPageMainSettingsPitch.Controls.Add(this.label204);
      this.tabPageMainSettingsPitch.Controls.Add(this.label205);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_SQUARE_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_SQUARE_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_RAMP_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label208);
      this.tabPageMainSettingsPitch.Controls.Add(this.label209);
      this.tabPageMainSettingsPitch.Controls.Add(this.label210);
      this.tabPageMainSettingsPitch.Controls.Add(this.label211);
      this.tabPageMainSettingsPitch.Controls.Add(this.label212);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_RAMP_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label213);
      this.tabPageMainSettingsPitch.Controls.Add(this.label214);
      this.tabPageMainSettingsPitch.Controls.Add(this.label215);
      this.tabPageMainSettingsPitch.Controls.Add(this.label216);
      this.tabPageMainSettingsPitch.Controls.Add(this.label217);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_CONSTANT_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_CONSTANT_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.lb_PITCH_TOTAL_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.label220);
      this.tabPageMainSettingsPitch.Controls.Add(this.label221);
      this.tabPageMainSettingsPitch.Controls.Add(this.label222);
      this.tabPageMainSettingsPitch.Controls.Add(this.label223);
      this.tabPageMainSettingsPitch.Controls.Add(this.label224);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_TOTAL_GAIN);
      this.tabPageMainSettingsPitch.Controls.Add(this.tb_PITCH_PWM_MAX);
      this.tabPageMainSettingsPitch.Location = new System.Drawing.Point(4, 22);
      this.tabPageMainSettingsPitch.Name = "tabPageMainSettingsPitch";
      this.tabPageMainSettingsPitch.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMainSettingsPitch.Size = new System.Drawing.Size(855, 601);
      this.tabPageMainSettingsPitch.TabIndex = 1;
      this.tabPageMainSettingsPitch.Text = "Pitch";
      // 
      // label119
      // 
      this.label119.AutoSize = true;
      this.label119.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label119.Location = new System.Drawing.Point(810, 52);
      this.label119.Name = "label119";
      this.label119.Size = new System.Drawing.Size(25, 13);
      this.label119.TabIndex = 274;
      this.label119.Text = "255";
      // 
      // label120
      // 
      this.label120.AutoSize = true;
      this.label120.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label120.Location = new System.Drawing.Point(524, 52);
      this.label120.Name = "label120";
      this.label120.Size = new System.Drawing.Size(25, 13);
      this.label120.TabIndex = 273;
      this.label120.Text = "255";
      // 
      // label121
      // 
      this.label121.AutoSize = true;
      this.label121.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label121.Location = new System.Drawing.Point(592, 52);
      this.label121.Name = "label121";
      this.label121.Size = new System.Drawing.Size(13, 13);
      this.label121.TabIndex = 272;
      this.label121.Text = "0";
      // 
      // label122
      // 
      this.label122.AutoSize = true;
      this.label122.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label122.Location = new System.Drawing.Point(305, 52);
      this.label122.Name = "label122";
      this.label122.Size = new System.Drawing.Size(13, 13);
      this.label122.TabIndex = 271;
      this.label122.Text = "0";
      // 
      // label123
      // 
      this.label123.AutoSize = true;
      this.label123.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label123.Location = new System.Drawing.Point(122, 53);
      this.label123.Name = "label123";
      this.label123.Size = new System.Drawing.Size(37, 13);
      this.label123.TabIndex = 270;
      this.label123.Text = "16250";
      // 
      // label124
      // 
      this.label124.AutoSize = true;
      this.label124.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label124.Location = new System.Drawing.Point(21, 52);
      this.label124.Name = "label124";
      this.label124.Size = new System.Drawing.Size(13, 13);
      this.label124.TabIndex = 269;
      this.label124.Text = "0";
      // 
      // label125
      // 
      this.label125.AutoSize = true;
      this.label125.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label125.Location = new System.Drawing.Point(225, 52);
      this.label125.Name = "label125";
      this.label125.Size = new System.Drawing.Size(37, 13);
      this.label125.TabIndex = 268;
      this.label125.Text = "32500";
      // 
      // lb_PITCH_PWM_MAX
      // 
      this.lb_PITCH_PWM_MAX.AutoSize = true;
      this.lb_PITCH_PWM_MAX.Location = new System.Drawing.Point(661, 6);
      this.lb_PITCH_PWM_MAX.Name = "lb_PITCH_PWM_MAX";
      this.lb_PITCH_PWM_MAX.Size = new System.Drawing.Size(90, 13);
      this.lb_PITCH_PWM_MAX.TabIndex = 267;
      this.lb_PITCH_PWM_MAX.Text = "Max Motor Power";
      // 
      // lb_PITCH_PWM_MIN
      // 
      this.lb_PITCH_PWM_MIN.AutoSize = true;
      this.lb_PITCH_PWM_MIN.Location = new System.Drawing.Point(373, 6);
      this.lb_PITCH_PWM_MIN.Name = "lb_PITCH_PWM_MIN";
      this.lb_PITCH_PWM_MIN.Size = new System.Drawing.Size(92, 13);
      this.lb_PITCH_PWM_MIN.TabIndex = 266;
      this.lb_PITCH_PWM_MIN.Text = "Start Motor Power";
      // 
      // tb_PITCH_PWM_MIN
      // 
      this.tb_PITCH_PWM_MIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_PWM_MIN.LargeChange = 10;
      this.tb_PITCH_PWM_MIN.Location = new System.Drawing.Point(298, 21);
      this.tb_PITCH_PWM_MIN.Maximum = 255;
      this.tb_PITCH_PWM_MIN.Name = "tb_PITCH_PWM_MIN";
      this.tb_PITCH_PWM_MIN.Size = new System.Drawing.Size(250, 45);
      this.tb_PITCH_PWM_MIN.TabIndex = 151;
      this.tb_PITCH_PWM_MIN.TickFrequency = 15;
      this.tb_PITCH_PWM_MIN.Scroll += new System.EventHandler(this.tb_PITCH_PWM_MIN_Scroll);
      this.tb_PITCH_PWM_MIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_FORCE_MAX
      // 
      this.lb_PITCH_FORCE_MAX.AutoSize = true;
      this.lb_PITCH_FORCE_MAX.Location = new System.Drawing.Point(79, 6);
      this.lb_PITCH_FORCE_MAX.Name = "lb_PITCH_FORCE_MAX";
      this.lb_PITCH_FORCE_MAX.Size = new System.Drawing.Size(106, 13);
      this.lb_PITCH_FORCE_MAX.TabIndex = 265;
      this.lb_PITCH_FORCE_MAX.Text = "Max Accepted Force";
      // 
      // tb_PITCH_FORCE_MAX
      // 
      this.tb_PITCH_FORCE_MAX.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_FORCE_MAX.LargeChange = 1000;
      this.tb_PITCH_FORCE_MAX.Location = new System.Drawing.Point(13, 21);
      this.tb_PITCH_FORCE_MAX.Maximum = 32500;
      this.tb_PITCH_FORCE_MAX.Name = "tb_PITCH_FORCE_MAX";
      this.tb_PITCH_FORCE_MAX.Size = new System.Drawing.Size(250, 45);
      this.tb_PITCH_FORCE_MAX.SmallChange = 100;
      this.tb_PITCH_FORCE_MAX.TabIndex = 150;
      this.tb_PITCH_FORCE_MAX.TickFrequency = 1500;
      this.tb_PITCH_FORCE_MAX.Scroll += new System.EventHandler(this.tb_PITCH_FORCE_MAX_Scroll);
      this.tb_PITCH_FORCE_MAX.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label129
      // 
      this.label129.AutoSize = true;
      this.label129.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label129.Location = new System.Drawing.Point(539, 561);
      this.label129.Name = "label129";
      this.label129.Size = new System.Drawing.Size(25, 13);
      this.label129.TabIndex = 264;
      this.label129.Text = "250";
      // 
      // label130
      // 
      this.label130.AutoSize = true;
      this.label130.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label130.Location = new System.Drawing.Point(727, 561);
      this.label130.Name = "label130";
      this.label130.Size = new System.Drawing.Size(25, 13);
      this.label130.TabIndex = 263;
      this.label130.Text = "750";
      // 
      // label131
      // 
      this.label131.AutoSize = true;
      this.label131.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label131.Location = new System.Drawing.Point(633, 561);
      this.label131.Name = "label131";
      this.label131.Size = new System.Drawing.Size(25, 13);
      this.label131.TabIndex = 262;
      this.label131.Text = "500";
      // 
      // label132
      // 
      this.label132.AutoSize = true;
      this.label132.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label132.Location = new System.Drawing.Point(810, 561);
      this.label132.Name = "label132";
      this.label132.Size = new System.Drawing.Size(31, 13);
      this.label132.TabIndex = 261;
      this.label132.Text = "1000";
      // 
      // label133
      // 
      this.label133.AutoSize = true;
      this.label133.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label133.Location = new System.Drawing.Point(452, 561);
      this.label133.Name = "label133";
      this.label133.Size = new System.Drawing.Size(13, 13);
      this.label133.TabIndex = 260;
      this.label133.Text = "0";
      // 
      // lb_PITCH_DAMPER_MAX_VELOCITY
      // 
      this.lb_PITCH_DAMPER_MAX_VELOCITY.AutoSize = true;
      this.lb_PITCH_DAMPER_MAX_VELOCITY.Location = new System.Drawing.Point(595, 518);
      this.lb_PITCH_DAMPER_MAX_VELOCITY.Name = "lb_PITCH_DAMPER_MAX_VELOCITY";
      this.lb_PITCH_DAMPER_MAX_VELOCITY.Size = new System.Drawing.Size(107, 13);
      this.lb_PITCH_DAMPER_MAX_VELOCITY.TabIndex = 259;
      this.lb_PITCH_DAMPER_MAX_VELOCITY.Text = "Damper Max Velocity";
      // 
      // tb_PITCH_DAMPER_MAX_VELOCITY
      // 
      this.tb_PITCH_DAMPER_MAX_VELOCITY.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_DAMPER_MAX_VELOCITY.LargeChange = 10;
      this.tb_PITCH_DAMPER_MAX_VELOCITY.Location = new System.Drawing.Point(444, 531);
      this.tb_PITCH_DAMPER_MAX_VELOCITY.Maximum = 1000;
      this.tb_PITCH_DAMPER_MAX_VELOCITY.Name = "tb_PITCH_DAMPER_MAX_VELOCITY";
      this.tb_PITCH_DAMPER_MAX_VELOCITY.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_DAMPER_MAX_VELOCITY.TabIndex = 168;
      this.tb_PITCH_DAMPER_MAX_VELOCITY.TickFrequency = 25;
      this.tb_PITCH_DAMPER_MAX_VELOCITY.Scroll += new System.EventHandler(this.tb_PITCH_DAMPER_MAX_VELOCITY_Scroll);
      this.tb_PITCH_DAMPER_MAX_VELOCITY.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_INERTIA_MAX_ACCELERATION
      // 
      this.lb_PITCH_INERTIA_MAX_ACCELERATION.AutoSize = true;
      this.lb_PITCH_INERTIA_MAX_ACCELERATION.Location = new System.Drawing.Point(155, 518);
      this.lb_PITCH_INERTIA_MAX_ACCELERATION.Name = "lb_PITCH_INERTIA_MAX_ACCELERATION";
      this.lb_PITCH_INERTIA_MAX_ACCELERATION.Size = new System.Drawing.Size(121, 13);
      this.lb_PITCH_INERTIA_MAX_ACCELERATION.TabIndex = 258;
      this.lb_PITCH_INERTIA_MAX_ACCELERATION.Text = "Inertia Max Acceleration";
      // 
      // label136
      // 
      this.label136.AutoSize = true;
      this.label136.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label136.Location = new System.Drawing.Point(108, 561);
      this.label136.Name = "label136";
      this.label136.Size = new System.Drawing.Size(25, 13);
      this.label136.TabIndex = 257;
      this.label136.Text = "250";
      // 
      // label137
      // 
      this.label137.AutoSize = true;
      this.label137.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label137.Location = new System.Drawing.Point(294, 561);
      this.label137.Name = "label137";
      this.label137.Size = new System.Drawing.Size(25, 13);
      this.label137.TabIndex = 256;
      this.label137.Text = "750";
      // 
      // label138
      // 
      this.label138.AutoSize = true;
      this.label138.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label138.Location = new System.Drawing.Point(200, 561);
      this.label138.Name = "label138";
      this.label138.Size = new System.Drawing.Size(25, 13);
      this.label138.TabIndex = 255;
      this.label138.Text = "500";
      // 
      // label139
      // 
      this.label139.AutoSize = true;
      this.label139.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label139.Location = new System.Drawing.Point(381, 561);
      this.label139.Name = "label139";
      this.label139.Size = new System.Drawing.Size(31, 13);
      this.label139.TabIndex = 254;
      this.label139.Text = "1000";
      // 
      // label140
      // 
      this.label140.AutoSize = true;
      this.label140.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label140.Location = new System.Drawing.Point(20, 561);
      this.label140.Name = "label140";
      this.label140.Size = new System.Drawing.Size(13, 13);
      this.label140.TabIndex = 253;
      this.label140.Text = "0";
      // 
      // tb_PITCH_INERTIA_MAX_ACCELERATION
      // 
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.LargeChange = 10;
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.Location = new System.Drawing.Point(13, 531);
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.Maximum = 1000;
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.Name = "tb_PITCH_INERTIA_MAX_ACCELERATION";
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.TabIndex = 167;
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.TickFrequency = 25;
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.Scroll += new System.EventHandler(this.tb_PITCH_INERTIA_MAX_ACCELERATION_Scroll);
      this.tb_PITCH_INERTIA_MAX_ACCELERATION.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label141
      // 
      this.label141.AutoSize = true;
      this.label141.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label141.Location = new System.Drawing.Point(108, 502);
      this.label141.Name = "label141";
      this.label141.Size = new System.Drawing.Size(25, 13);
      this.label141.TabIndex = 252;
      this.label141.Text = "250";
      // 
      // label142
      // 
      this.label142.AutoSize = true;
      this.label142.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label142.Location = new System.Drawing.Point(295, 502);
      this.label142.Name = "label142";
      this.label142.Size = new System.Drawing.Size(25, 13);
      this.label142.TabIndex = 251;
      this.label142.Text = "750";
      // 
      // label143
      // 
      this.label143.AutoSize = true;
      this.label143.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label143.Location = new System.Drawing.Point(203, 502);
      this.label143.Name = "label143";
      this.label143.Size = new System.Drawing.Size(25, 13);
      this.label143.TabIndex = 250;
      this.label143.Text = "500";
      // 
      // label144
      // 
      this.label144.AutoSize = true;
      this.label144.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label144.Location = new System.Drawing.Point(379, 502);
      this.label144.Name = "label144";
      this.label144.Size = new System.Drawing.Size(31, 13);
      this.label144.TabIndex = 249;
      this.label144.Text = "1000";
      // 
      // label145
      // 
      this.label145.AutoSize = true;
      this.label145.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label145.Location = new System.Drawing.Point(21, 502);
      this.label145.Name = "label145";
      this.label145.Size = new System.Drawing.Size(13, 13);
      this.label145.TabIndex = 248;
      this.label145.Text = "0";
      // 
      // lb_PITCH_FRICTION_MAX_POSITION_CHANGE
      // 
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE.AutoSize = true;
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE.Location = new System.Drawing.Point(144, 457);
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE.Name = "lb_PITCH_FRICTION_MAX_POSITION_CHANGE";
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE.Size = new System.Drawing.Size(144, 13);
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE.TabIndex = 247;
      this.lb_PITCH_FRICTION_MAX_POSITION_CHANGE.Text = "Friction Max Position Change";
      // 
      // tb_PITCH_FRICTION_MAX_POSITION_CHANGE
      // 
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.LargeChange = 10;
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Location = new System.Drawing.Point(13, 470);
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Maximum = 1000;
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Name = "tb_PITCH_FRICTION_MAX_POSITION_CHANGE";
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.TabIndex = 166;
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.TickFrequency = 25;
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Scroll += new System.EventHandler(this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE_Scroll);
      this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_FRICTION_GAIN
      // 
      this.lb_PITCH_FRICTION_GAIN.AutoSize = true;
      this.lb_PITCH_FRICTION_GAIN.Location = new System.Drawing.Point(612, 389);
      this.lb_PITCH_FRICTION_GAIN.Name = "lb_PITCH_FRICTION_GAIN";
      this.lb_PITCH_FRICTION_GAIN.Size = new System.Drawing.Size(66, 13);
      this.lb_PITCH_FRICTION_GAIN.TabIndex = 246;
      this.lb_PITCH_FRICTION_GAIN.Text = "Friction Gain";
      // 
      // label148
      // 
      this.label148.AutoSize = true;
      this.label148.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label148.Location = new System.Drawing.Point(539, 434);
      this.label148.Name = "label148";
      this.label148.Size = new System.Drawing.Size(19, 13);
      this.label148.TabIndex = 245;
      this.label148.Text = "25";
      // 
      // label149
      // 
      this.label149.AutoSize = true;
      this.label149.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label149.Location = new System.Drawing.Point(729, 434);
      this.label149.Name = "label149";
      this.label149.Size = new System.Drawing.Size(19, 13);
      this.label149.TabIndex = 244;
      this.label149.Text = "75";
      // 
      // label150
      // 
      this.label150.AutoSize = true;
      this.label150.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label150.Location = new System.Drawing.Point(635, 434);
      this.label150.Name = "label150";
      this.label150.Size = new System.Drawing.Size(19, 13);
      this.label150.TabIndex = 243;
      this.label150.Text = "50";
      // 
      // label151
      // 
      this.label151.AutoSize = true;
      this.label151.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label151.Location = new System.Drawing.Point(819, 434);
      this.label151.Name = "label151";
      this.label151.Size = new System.Drawing.Size(25, 13);
      this.label151.TabIndex = 242;
      this.label151.Text = "100";
      // 
      // label152
      // 
      this.label152.AutoSize = true;
      this.label152.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label152.Location = new System.Drawing.Point(451, 434);
      this.label152.Name = "label152";
      this.label152.Size = new System.Drawing.Size(13, 13);
      this.label152.TabIndex = 241;
      this.label152.Text = "0";
      // 
      // tb_PITCH_FRICTION_GAIN
      // 
      this.tb_PITCH_FRICTION_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_FRICTION_GAIN.LargeChange = 10;
      this.tb_PITCH_FRICTION_GAIN.Location = new System.Drawing.Point(444, 402);
      this.tb_PITCH_FRICTION_GAIN.Maximum = 100;
      this.tb_PITCH_FRICTION_GAIN.Name = "tb_PITCH_FRICTION_GAIN";
      this.tb_PITCH_FRICTION_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_FRICTION_GAIN.TabIndex = 165;
      this.tb_PITCH_FRICTION_GAIN.TickFrequency = 5;
      this.tb_PITCH_FRICTION_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_FRICTION_GAIN_Scroll);
      this.tb_PITCH_FRICTION_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_INERTIA_GAIN
      // 
      this.lb_PITCH_INERTIA_GAIN.AutoSize = true;
      this.lb_PITCH_INERTIA_GAIN.Location = new System.Drawing.Point(181, 388);
      this.lb_PITCH_INERTIA_GAIN.Name = "lb_PITCH_INERTIA_GAIN";
      this.lb_PITCH_INERTIA_GAIN.Size = new System.Drawing.Size(61, 13);
      this.lb_PITCH_INERTIA_GAIN.TabIndex = 234;
      this.lb_PITCH_INERTIA_GAIN.Text = "Inertia Gain";
      // 
      // label160
      // 
      this.label160.AutoSize = true;
      this.label160.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label160.Location = new System.Drawing.Point(108, 434);
      this.label160.Name = "label160";
      this.label160.Size = new System.Drawing.Size(19, 13);
      this.label160.TabIndex = 233;
      this.label160.Text = "25";
      // 
      // label161
      // 
      this.label161.AutoSize = true;
      this.label161.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label161.Location = new System.Drawing.Point(299, 434);
      this.label161.Name = "label161";
      this.label161.Size = new System.Drawing.Size(19, 13);
      this.label161.TabIndex = 232;
      this.label161.Text = "75";
      // 
      // label162
      // 
      this.label162.AutoSize = true;
      this.label162.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label162.Location = new System.Drawing.Point(204, 434);
      this.label162.Name = "label162";
      this.label162.Size = new System.Drawing.Size(19, 13);
      this.label162.TabIndex = 231;
      this.label162.Text = "50";
      // 
      // label163
      // 
      this.label163.AutoSize = true;
      this.label163.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label163.Location = new System.Drawing.Point(388, 434);
      this.label163.Name = "label163";
      this.label163.Size = new System.Drawing.Size(25, 13);
      this.label163.TabIndex = 230;
      this.label163.Text = "100";
      // 
      // label164
      // 
      this.label164.AutoSize = true;
      this.label164.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label164.Location = new System.Drawing.Point(20, 434);
      this.label164.Name = "label164";
      this.label164.Size = new System.Drawing.Size(13, 13);
      this.label164.TabIndex = 229;
      this.label164.Text = "0";
      // 
      // tb_PITCH_INERTIA_GAIN
      // 
      this.tb_PITCH_INERTIA_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_INERTIA_GAIN.LargeChange = 10;
      this.tb_PITCH_INERTIA_GAIN.Location = new System.Drawing.Point(13, 402);
      this.tb_PITCH_INERTIA_GAIN.Maximum = 100;
      this.tb_PITCH_INERTIA_GAIN.Name = "tb_PITCH_INERTIA_GAIN";
      this.tb_PITCH_INERTIA_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_INERTIA_GAIN.TabIndex = 163;
      this.tb_PITCH_INERTIA_GAIN.TickFrequency = 5;
      this.tb_PITCH_INERTIA_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_INERTIA_GAIN_Scroll);
      this.tb_PITCH_INERTIA_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label165
      // 
      this.label165.AutoSize = true;
      this.label165.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label165.Location = new System.Drawing.Point(540, 370);
      this.label165.Name = "label165";
      this.label165.Size = new System.Drawing.Size(19, 13);
      this.label165.TabIndex = 228;
      this.label165.Text = "25";
      // 
      // label166
      // 
      this.label166.AutoSize = true;
      this.label166.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label166.Location = new System.Drawing.Point(731, 370);
      this.label166.Name = "label166";
      this.label166.Size = new System.Drawing.Size(19, 13);
      this.label166.TabIndex = 227;
      this.label166.Text = "75";
      // 
      // label167
      // 
      this.label167.AutoSize = true;
      this.label167.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label167.Location = new System.Drawing.Point(636, 370);
      this.label167.Name = "label167";
      this.label167.Size = new System.Drawing.Size(19, 13);
      this.label167.TabIndex = 226;
      this.label167.Text = "50";
      // 
      // label168
      // 
      this.label168.AutoSize = true;
      this.label168.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label168.Location = new System.Drawing.Point(816, 370);
      this.label168.Name = "label168";
      this.label168.Size = new System.Drawing.Size(25, 13);
      this.label168.TabIndex = 225;
      this.label168.Text = "100";
      // 
      // label169
      // 
      this.label169.AutoSize = true;
      this.label169.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label169.Location = new System.Drawing.Point(452, 370);
      this.label169.Name = "label169";
      this.label169.Size = new System.Drawing.Size(13, 13);
      this.label169.TabIndex = 224;
      this.label169.Text = "0";
      // 
      // lb_PITCH_DAMPER_GAIN
      // 
      this.lb_PITCH_DAMPER_GAIN.AutoSize = true;
      this.lb_PITCH_DAMPER_GAIN.Location = new System.Drawing.Point(613, 327);
      this.lb_PITCH_DAMPER_GAIN.Name = "lb_PITCH_DAMPER_GAIN";
      this.lb_PITCH_DAMPER_GAIN.Size = new System.Drawing.Size(69, 13);
      this.lb_PITCH_DAMPER_GAIN.TabIndex = 223;
      this.lb_PITCH_DAMPER_GAIN.Text = "Damper Gain";
      // 
      // tb_PITCH_DAMPER_GAIN
      // 
      this.tb_PITCH_DAMPER_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_DAMPER_GAIN.LargeChange = 10;
      this.tb_PITCH_DAMPER_GAIN.Location = new System.Drawing.Point(444, 340);
      this.tb_PITCH_DAMPER_GAIN.Maximum = 100;
      this.tb_PITCH_DAMPER_GAIN.Name = "tb_PITCH_DAMPER_GAIN";
      this.tb_PITCH_DAMPER_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_DAMPER_GAIN.TabIndex = 162;
      this.tb_PITCH_DAMPER_GAIN.TickFrequency = 5;
      this.tb_PITCH_DAMPER_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_DAMPER_GAIN_Scroll);
      this.tb_PITCH_DAMPER_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_SPRING_GAIN
      // 
      this.lb_PITCH_SPRING_GAIN.AutoSize = true;
      this.lb_PITCH_SPRING_GAIN.Location = new System.Drawing.Point(180, 327);
      this.lb_PITCH_SPRING_GAIN.Name = "lb_PITCH_SPRING_GAIN";
      this.lb_PITCH_SPRING_GAIN.Size = new System.Drawing.Size(62, 13);
      this.lb_PITCH_SPRING_GAIN.TabIndex = 222;
      this.lb_PITCH_SPRING_GAIN.Text = "Spring Gain";
      // 
      // label172
      // 
      this.label172.AutoSize = true;
      this.label172.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label172.Location = new System.Drawing.Point(108, 370);
      this.label172.Name = "label172";
      this.label172.Size = new System.Drawing.Size(19, 13);
      this.label172.TabIndex = 221;
      this.label172.Text = "25";
      // 
      // label173
      // 
      this.label173.AutoSize = true;
      this.label173.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label173.Location = new System.Drawing.Point(299, 370);
      this.label173.Name = "label173";
      this.label173.Size = new System.Drawing.Size(19, 13);
      this.label173.TabIndex = 220;
      this.label173.Text = "75";
      // 
      // label174
      // 
      this.label174.AutoSize = true;
      this.label174.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label174.Location = new System.Drawing.Point(204, 370);
      this.label174.Name = "label174";
      this.label174.Size = new System.Drawing.Size(19, 13);
      this.label174.TabIndex = 219;
      this.label174.Text = "50";
      // 
      // label175
      // 
      this.label175.AutoSize = true;
      this.label175.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label175.Location = new System.Drawing.Point(388, 370);
      this.label175.Name = "label175";
      this.label175.Size = new System.Drawing.Size(25, 13);
      this.label175.TabIndex = 218;
      this.label175.Text = "100";
      // 
      // label176
      // 
      this.label176.AutoSize = true;
      this.label176.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label176.Location = new System.Drawing.Point(20, 370);
      this.label176.Name = "label176";
      this.label176.Size = new System.Drawing.Size(13, 13);
      this.label176.TabIndex = 217;
      this.label176.Text = "0";
      // 
      // tb_PITCH_SPRING_GAIN
      // 
      this.tb_PITCH_SPRING_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_SPRING_GAIN.LargeChange = 10;
      this.tb_PITCH_SPRING_GAIN.Location = new System.Drawing.Point(13, 340);
      this.tb_PITCH_SPRING_GAIN.Maximum = 100;
      this.tb_PITCH_SPRING_GAIN.Name = "tb_PITCH_SPRING_GAIN";
      this.tb_PITCH_SPRING_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_SPRING_GAIN.TabIndex = 161;
      this.tb_PITCH_SPRING_GAIN.TickFrequency = 5;
      this.tb_PITCH_SPRING_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_SPRING_GAIN_Scroll);
      this.tb_PITCH_SPRING_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label177
      // 
      this.label177.AutoSize = true;
      this.label177.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label177.Location = new System.Drawing.Point(540, 306);
      this.label177.Name = "label177";
      this.label177.Size = new System.Drawing.Size(19, 13);
      this.label177.TabIndex = 216;
      this.label177.Text = "25";
      // 
      // label178
      // 
      this.label178.AutoSize = true;
      this.label178.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label178.Location = new System.Drawing.Point(731, 306);
      this.label178.Name = "label178";
      this.label178.Size = new System.Drawing.Size(19, 13);
      this.label178.TabIndex = 215;
      this.label178.Text = "75";
      // 
      // label179
      // 
      this.label179.AutoSize = true;
      this.label179.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label179.Location = new System.Drawing.Point(636, 306);
      this.label179.Name = "label179";
      this.label179.Size = new System.Drawing.Size(19, 13);
      this.label179.TabIndex = 214;
      this.label179.Text = "50";
      // 
      // label180
      // 
      this.label180.AutoSize = true;
      this.label180.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label180.Location = new System.Drawing.Point(816, 306);
      this.label180.Name = "label180";
      this.label180.Size = new System.Drawing.Size(25, 13);
      this.label180.TabIndex = 213;
      this.label180.Text = "100";
      // 
      // label181
      // 
      this.label181.AutoSize = true;
      this.label181.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label181.Location = new System.Drawing.Point(452, 306);
      this.label181.Name = "label181";
      this.label181.Size = new System.Drawing.Size(13, 13);
      this.label181.TabIndex = 212;
      this.label181.Text = "0";
      // 
      // lb_PITCH_SAWTOOTH_UP_GAIN
      // 
      this.lb_PITCH_SAWTOOTH_UP_GAIN.AutoSize = true;
      this.lb_PITCH_SAWTOOTH_UP_GAIN.Location = new System.Drawing.Point(607, 260);
      this.lb_PITCH_SAWTOOTH_UP_GAIN.Name = "lb_PITCH_SAWTOOTH_UP_GAIN";
      this.lb_PITCH_SAWTOOTH_UP_GAIN.Size = new System.Drawing.Size(94, 13);
      this.lb_PITCH_SAWTOOTH_UP_GAIN.TabIndex = 211;
      this.lb_PITCH_SAWTOOTH_UP_GAIN.Text = "Sawtooth Up Gain";
      // 
      // tb_PITCH_SAWTOOTH_UP_GAIN
      // 
      this.tb_PITCH_SAWTOOTH_UP_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_SAWTOOTH_UP_GAIN.LargeChange = 10;
      this.tb_PITCH_SAWTOOTH_UP_GAIN.Location = new System.Drawing.Point(444, 274);
      this.tb_PITCH_SAWTOOTH_UP_GAIN.Maximum = 100;
      this.tb_PITCH_SAWTOOTH_UP_GAIN.Name = "tb_PITCH_SAWTOOTH_UP_GAIN";
      this.tb_PITCH_SAWTOOTH_UP_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_SAWTOOTH_UP_GAIN.TabIndex = 160;
      this.tb_PITCH_SAWTOOTH_UP_GAIN.TickFrequency = 5;
      this.tb_PITCH_SAWTOOTH_UP_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_SAWTOOT_UP_GAIN_Scroll);
      this.tb_PITCH_SAWTOOTH_UP_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_SAWTOOT_DOWN_GAIN
      // 
      this.lb_PITCH_SAWTOOT_DOWN_GAIN.AutoSize = true;
      this.lb_PITCH_SAWTOOT_DOWN_GAIN.Location = new System.Drawing.Point(168, 260);
      this.lb_PITCH_SAWTOOT_DOWN_GAIN.Name = "lb_PITCH_SAWTOOT_DOWN_GAIN";
      this.lb_PITCH_SAWTOOT_DOWN_GAIN.Size = new System.Drawing.Size(108, 13);
      this.lb_PITCH_SAWTOOT_DOWN_GAIN.TabIndex = 210;
      this.lb_PITCH_SAWTOOT_DOWN_GAIN.Text = "Sawtooth Down Gain";
      // 
      // label184
      // 
      this.label184.AutoSize = true;
      this.label184.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label184.Location = new System.Drawing.Point(108, 306);
      this.label184.Name = "label184";
      this.label184.Size = new System.Drawing.Size(19, 13);
      this.label184.TabIndex = 209;
      this.label184.Text = "25";
      // 
      // label185
      // 
      this.label185.AutoSize = true;
      this.label185.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label185.Location = new System.Drawing.Point(299, 306);
      this.label185.Name = "label185";
      this.label185.Size = new System.Drawing.Size(19, 13);
      this.label185.TabIndex = 208;
      this.label185.Text = "75";
      // 
      // label186
      // 
      this.label186.AutoSize = true;
      this.label186.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label186.Location = new System.Drawing.Point(204, 306);
      this.label186.Name = "label186";
      this.label186.Size = new System.Drawing.Size(19, 13);
      this.label186.TabIndex = 207;
      this.label186.Text = "50";
      // 
      // label187
      // 
      this.label187.AutoSize = true;
      this.label187.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label187.Location = new System.Drawing.Point(388, 306);
      this.label187.Name = "label187";
      this.label187.Size = new System.Drawing.Size(25, 13);
      this.label187.TabIndex = 206;
      this.label187.Text = "100";
      // 
      // label188
      // 
      this.label188.AutoSize = true;
      this.label188.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label188.Location = new System.Drawing.Point(20, 306);
      this.label188.Name = "label188";
      this.label188.Size = new System.Drawing.Size(13, 13);
      this.label188.TabIndex = 205;
      this.label188.Text = "0";
      // 
      // tb_PITCH_SAWTOOT_DOWN_GAIN
      // 
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.LargeChange = 10;
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.Location = new System.Drawing.Point(13, 274);
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.Maximum = 100;
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.Name = "tb_PITCH_SAWTOOT_DOWN_GAIN";
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.TabIndex = 159;
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.TickFrequency = 5;
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_SAWTOOT_DOWN_GAIN_Scroll);
      this.tb_PITCH_SAWTOOT_DOWN_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label189
      // 
      this.label189.AutoSize = true;
      this.label189.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label189.Location = new System.Drawing.Point(540, 244);
      this.label189.Name = "label189";
      this.label189.Size = new System.Drawing.Size(19, 13);
      this.label189.TabIndex = 204;
      this.label189.Text = "25";
      // 
      // label190
      // 
      this.label190.AutoSize = true;
      this.label190.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label190.Location = new System.Drawing.Point(731, 244);
      this.label190.Name = "label190";
      this.label190.Size = new System.Drawing.Size(19, 13);
      this.label190.TabIndex = 203;
      this.label190.Text = "75";
      // 
      // label191
      // 
      this.label191.AutoSize = true;
      this.label191.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label191.Location = new System.Drawing.Point(636, 244);
      this.label191.Name = "label191";
      this.label191.Size = new System.Drawing.Size(19, 13);
      this.label191.TabIndex = 202;
      this.label191.Text = "50";
      // 
      // label192
      // 
      this.label192.AutoSize = true;
      this.label192.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label192.Location = new System.Drawing.Point(816, 244);
      this.label192.Name = "label192";
      this.label192.Size = new System.Drawing.Size(25, 13);
      this.label192.TabIndex = 201;
      this.label192.Text = "100";
      // 
      // label193
      // 
      this.label193.AutoSize = true;
      this.label193.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label193.Location = new System.Drawing.Point(452, 244);
      this.label193.Name = "label193";
      this.label193.Size = new System.Drawing.Size(13, 13);
      this.label193.TabIndex = 200;
      this.label193.Text = "0";
      // 
      // lb_PITCH_TRIANGLE_GAIN
      // 
      this.lb_PITCH_TRIANGLE_GAIN.AutoSize = true;
      this.lb_PITCH_TRIANGLE_GAIN.Location = new System.Drawing.Point(613, 199);
      this.lb_PITCH_TRIANGLE_GAIN.Name = "lb_PITCH_TRIANGLE_GAIN";
      this.lb_PITCH_TRIANGLE_GAIN.Size = new System.Drawing.Size(70, 13);
      this.lb_PITCH_TRIANGLE_GAIN.TabIndex = 199;
      this.lb_PITCH_TRIANGLE_GAIN.Text = "Triangle Gain";
      // 
      // tb_PITCH_TRIANGLE_GAIN
      // 
      this.tb_PITCH_TRIANGLE_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_TRIANGLE_GAIN.LargeChange = 10;
      this.tb_PITCH_TRIANGLE_GAIN.Location = new System.Drawing.Point(444, 212);
      this.tb_PITCH_TRIANGLE_GAIN.Maximum = 100;
      this.tb_PITCH_TRIANGLE_GAIN.Name = "tb_PITCH_TRIANGLE_GAIN";
      this.tb_PITCH_TRIANGLE_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_TRIANGLE_GAIN.TabIndex = 158;
      this.tb_PITCH_TRIANGLE_GAIN.TickFrequency = 5;
      this.tb_PITCH_TRIANGLE_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_TRIANGLE_GAIN_Scroll);
      this.tb_PITCH_TRIANGLE_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_SIN_GAIN
      // 
      this.lb_PITCH_SIN_GAIN.AutoSize = true;
      this.lb_PITCH_SIN_GAIN.Location = new System.Drawing.Point(189, 199);
      this.lb_PITCH_SIN_GAIN.Name = "lb_PITCH_SIN_GAIN";
      this.lb_PITCH_SIN_GAIN.Size = new System.Drawing.Size(53, 13);
      this.lb_PITCH_SIN_GAIN.TabIndex = 198;
      this.lb_PITCH_SIN_GAIN.Text = "Sine Gain";
      // 
      // label196
      // 
      this.label196.AutoSize = true;
      this.label196.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label196.Location = new System.Drawing.Point(108, 244);
      this.label196.Name = "label196";
      this.label196.Size = new System.Drawing.Size(19, 13);
      this.label196.TabIndex = 197;
      this.label196.Text = "25";
      // 
      // label197
      // 
      this.label197.AutoSize = true;
      this.label197.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label197.Location = new System.Drawing.Point(299, 244);
      this.label197.Name = "label197";
      this.label197.Size = new System.Drawing.Size(19, 13);
      this.label197.TabIndex = 196;
      this.label197.Text = "75";
      // 
      // label198
      // 
      this.label198.AutoSize = true;
      this.label198.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label198.Location = new System.Drawing.Point(204, 244);
      this.label198.Name = "label198";
      this.label198.Size = new System.Drawing.Size(19, 13);
      this.label198.TabIndex = 195;
      this.label198.Text = "50";
      // 
      // label199
      // 
      this.label199.AutoSize = true;
      this.label199.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label199.Location = new System.Drawing.Point(388, 244);
      this.label199.Name = "label199";
      this.label199.Size = new System.Drawing.Size(25, 13);
      this.label199.TabIndex = 194;
      this.label199.Text = "100";
      // 
      // label200
      // 
      this.label200.AutoSize = true;
      this.label200.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label200.Location = new System.Drawing.Point(20, 244);
      this.label200.Name = "label200";
      this.label200.Size = new System.Drawing.Size(13, 13);
      this.label200.TabIndex = 193;
      this.label200.Text = "0";
      // 
      // tb_PITCH_SIN_GAIN
      // 
      this.tb_PITCH_SIN_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_SIN_GAIN.LargeChange = 10;
      this.tb_PITCH_SIN_GAIN.Location = new System.Drawing.Point(13, 212);
      this.tb_PITCH_SIN_GAIN.Maximum = 100;
      this.tb_PITCH_SIN_GAIN.Name = "tb_PITCH_SIN_GAIN";
      this.tb_PITCH_SIN_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_SIN_GAIN.TabIndex = 157;
      this.tb_PITCH_SIN_GAIN.TickFrequency = 5;
      this.tb_PITCH_SIN_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_SIN_GAIN_Scroll);
      this.tb_PITCH_SIN_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label201
      // 
      this.label201.AutoSize = true;
      this.label201.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label201.Location = new System.Drawing.Point(540, 175);
      this.label201.Name = "label201";
      this.label201.Size = new System.Drawing.Size(19, 13);
      this.label201.TabIndex = 192;
      this.label201.Text = "25";
      // 
      // label202
      // 
      this.label202.AutoSize = true;
      this.label202.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label202.Location = new System.Drawing.Point(731, 175);
      this.label202.Name = "label202";
      this.label202.Size = new System.Drawing.Size(19, 13);
      this.label202.TabIndex = 191;
      this.label202.Text = "75";
      // 
      // label203
      // 
      this.label203.AutoSize = true;
      this.label203.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label203.Location = new System.Drawing.Point(636, 175);
      this.label203.Name = "label203";
      this.label203.Size = new System.Drawing.Size(19, 13);
      this.label203.TabIndex = 190;
      this.label203.Text = "50";
      // 
      // label204
      // 
      this.label204.AutoSize = true;
      this.label204.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label204.Location = new System.Drawing.Point(816, 175);
      this.label204.Name = "label204";
      this.label204.Size = new System.Drawing.Size(25, 13);
      this.label204.TabIndex = 189;
      this.label204.Text = "100";
      // 
      // label205
      // 
      this.label205.AutoSize = true;
      this.label205.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label205.Location = new System.Drawing.Point(452, 175);
      this.label205.Name = "label205";
      this.label205.Size = new System.Drawing.Size(13, 13);
      this.label205.TabIndex = 188;
      this.label205.Text = "0";
      // 
      // lb_PITCH_SQUARE_GAIN
      // 
      this.lb_PITCH_SQUARE_GAIN.AutoSize = true;
      this.lb_PITCH_SQUARE_GAIN.Location = new System.Drawing.Point(616, 132);
      this.lb_PITCH_SQUARE_GAIN.Name = "lb_PITCH_SQUARE_GAIN";
      this.lb_PITCH_SQUARE_GAIN.Size = new System.Drawing.Size(66, 13);
      this.lb_PITCH_SQUARE_GAIN.TabIndex = 187;
      this.lb_PITCH_SQUARE_GAIN.Text = "Square Gain";
      // 
      // tb_PITCH_SQUARE_GAIN
      // 
      this.tb_PITCH_SQUARE_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_SQUARE_GAIN.LargeChange = 10;
      this.tb_PITCH_SQUARE_GAIN.Location = new System.Drawing.Point(444, 145);
      this.tb_PITCH_SQUARE_GAIN.Maximum = 100;
      this.tb_PITCH_SQUARE_GAIN.Name = "tb_PITCH_SQUARE_GAIN";
      this.tb_PITCH_SQUARE_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_SQUARE_GAIN.TabIndex = 156;
      this.tb_PITCH_SQUARE_GAIN.TickFrequency = 5;
      this.tb_PITCH_SQUARE_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_SQUARE_GAIN_Scroll);
      this.tb_PITCH_SQUARE_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_RAMP_GAIN
      // 
      this.lb_PITCH_RAMP_GAIN.AutoSize = true;
      this.lb_PITCH_RAMP_GAIN.Location = new System.Drawing.Point(187, 132);
      this.lb_PITCH_RAMP_GAIN.Name = "lb_PITCH_RAMP_GAIN";
      this.lb_PITCH_RAMP_GAIN.Size = new System.Drawing.Size(60, 13);
      this.lb_PITCH_RAMP_GAIN.TabIndex = 186;
      this.lb_PITCH_RAMP_GAIN.Text = "Ramp Gain";
      // 
      // label208
      // 
      this.label208.AutoSize = true;
      this.label208.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label208.Location = new System.Drawing.Point(108, 175);
      this.label208.Name = "label208";
      this.label208.Size = new System.Drawing.Size(19, 13);
      this.label208.TabIndex = 185;
      this.label208.Text = "25";
      // 
      // label209
      // 
      this.label209.AutoSize = true;
      this.label209.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label209.Location = new System.Drawing.Point(299, 175);
      this.label209.Name = "label209";
      this.label209.Size = new System.Drawing.Size(19, 13);
      this.label209.TabIndex = 184;
      this.label209.Text = "75";
      // 
      // label210
      // 
      this.label210.AutoSize = true;
      this.label210.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label210.Location = new System.Drawing.Point(204, 175);
      this.label210.Name = "label210";
      this.label210.Size = new System.Drawing.Size(19, 13);
      this.label210.TabIndex = 183;
      this.label210.Text = "50";
      // 
      // label211
      // 
      this.label211.AutoSize = true;
      this.label211.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label211.Location = new System.Drawing.Point(388, 175);
      this.label211.Name = "label211";
      this.label211.Size = new System.Drawing.Size(25, 13);
      this.label211.TabIndex = 182;
      this.label211.Text = "100";
      // 
      // label212
      // 
      this.label212.AutoSize = true;
      this.label212.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label212.Location = new System.Drawing.Point(20, 175);
      this.label212.Name = "label212";
      this.label212.Size = new System.Drawing.Size(13, 13);
      this.label212.TabIndex = 181;
      this.label212.Text = "0";
      // 
      // tb_PITCH_RAMP_GAIN
      // 
      this.tb_PITCH_RAMP_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_RAMP_GAIN.LargeChange = 10;
      this.tb_PITCH_RAMP_GAIN.Location = new System.Drawing.Point(13, 145);
      this.tb_PITCH_RAMP_GAIN.Maximum = 100;
      this.tb_PITCH_RAMP_GAIN.Name = "tb_PITCH_RAMP_GAIN";
      this.tb_PITCH_RAMP_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_RAMP_GAIN.TabIndex = 155;
      this.tb_PITCH_RAMP_GAIN.TickFrequency = 5;
      this.tb_PITCH_RAMP_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_RAMP_GAIN_Scroll);
      this.tb_PITCH_RAMP_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // label213
      // 
      this.label213.AutoSize = true;
      this.label213.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label213.Location = new System.Drawing.Point(540, 115);
      this.label213.Name = "label213";
      this.label213.Size = new System.Drawing.Size(19, 13);
      this.label213.TabIndex = 180;
      this.label213.Text = "25";
      // 
      // label214
      // 
      this.label214.AutoSize = true;
      this.label214.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label214.Location = new System.Drawing.Point(731, 115);
      this.label214.Name = "label214";
      this.label214.Size = new System.Drawing.Size(19, 13);
      this.label214.TabIndex = 179;
      this.label214.Text = "75";
      // 
      // label215
      // 
      this.label215.AutoSize = true;
      this.label215.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label215.Location = new System.Drawing.Point(636, 115);
      this.label215.Name = "label215";
      this.label215.Size = new System.Drawing.Size(19, 13);
      this.label215.TabIndex = 178;
      this.label215.Text = "50";
      // 
      // label216
      // 
      this.label216.AutoSize = true;
      this.label216.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label216.Location = new System.Drawing.Point(816, 115);
      this.label216.Name = "label216";
      this.label216.Size = new System.Drawing.Size(25, 13);
      this.label216.TabIndex = 177;
      this.label216.Text = "100";
      // 
      // label217
      // 
      this.label217.AutoSize = true;
      this.label217.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label217.Location = new System.Drawing.Point(452, 115);
      this.label217.Name = "label217";
      this.label217.Size = new System.Drawing.Size(13, 13);
      this.label217.TabIndex = 176;
      this.label217.Text = "0";
      // 
      // lb_PITCH_CONSTANT_GAIN
      // 
      this.lb_PITCH_CONSTANT_GAIN.AutoSize = true;
      this.lb_PITCH_CONSTANT_GAIN.Location = new System.Drawing.Point(607, 69);
      this.lb_PITCH_CONSTANT_GAIN.Name = "lb_PITCH_CONSTANT_GAIN";
      this.lb_PITCH_CONSTANT_GAIN.Size = new System.Drawing.Size(74, 13);
      this.lb_PITCH_CONSTANT_GAIN.TabIndex = 175;
      this.lb_PITCH_CONSTANT_GAIN.Text = "Constant Gain";
      // 
      // tb_PITCH_CONSTANT_GAIN
      // 
      this.tb_PITCH_CONSTANT_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_CONSTANT_GAIN.LargeChange = 10;
      this.tb_PITCH_CONSTANT_GAIN.Location = new System.Drawing.Point(444, 83);
      this.tb_PITCH_CONSTANT_GAIN.Maximum = 100;
      this.tb_PITCH_CONSTANT_GAIN.Name = "tb_PITCH_CONSTANT_GAIN";
      this.tb_PITCH_CONSTANT_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_CONSTANT_GAIN.TabIndex = 154;
      this.tb_PITCH_CONSTANT_GAIN.TickFrequency = 5;
      this.tb_PITCH_CONSTANT_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_CONSTANT_GAIN_Scroll);
      this.tb_PITCH_CONSTANT_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // lb_PITCH_TOTAL_GAIN
      // 
      this.lb_PITCH_TOTAL_GAIN.AutoSize = true;
      this.lb_PITCH_TOTAL_GAIN.Location = new System.Drawing.Point(187, 69);
      this.lb_PITCH_TOTAL_GAIN.Name = "lb_PITCH_TOTAL_GAIN";
      this.lb_PITCH_TOTAL_GAIN.Size = new System.Drawing.Size(56, 13);
      this.lb_PITCH_TOTAL_GAIN.TabIndex = 174;
      this.lb_PITCH_TOTAL_GAIN.Text = "Total Gain";
      // 
      // label220
      // 
      this.label220.AutoSize = true;
      this.label220.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label220.Location = new System.Drawing.Point(108, 115);
      this.label220.Name = "label220";
      this.label220.Size = new System.Drawing.Size(19, 13);
      this.label220.TabIndex = 173;
      this.label220.Text = "25";
      // 
      // label221
      // 
      this.label221.AutoSize = true;
      this.label221.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label221.Location = new System.Drawing.Point(299, 115);
      this.label221.Name = "label221";
      this.label221.Size = new System.Drawing.Size(19, 13);
      this.label221.TabIndex = 172;
      this.label221.Text = "75";
      // 
      // label222
      // 
      this.label222.AutoSize = true;
      this.label222.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label222.Location = new System.Drawing.Point(204, 115);
      this.label222.Name = "label222";
      this.label222.Size = new System.Drawing.Size(19, 13);
      this.label222.TabIndex = 171;
      this.label222.Text = "50";
      // 
      // label223
      // 
      this.label223.AutoSize = true;
      this.label223.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label223.Location = new System.Drawing.Point(388, 115);
      this.label223.Name = "label223";
      this.label223.Size = new System.Drawing.Size(25, 13);
      this.label223.TabIndex = 170;
      this.label223.Text = "100";
      // 
      // label224
      // 
      this.label224.AutoSize = true;
      this.label224.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.label224.Location = new System.Drawing.Point(20, 115);
      this.label224.Name = "label224";
      this.label224.Size = new System.Drawing.Size(13, 13);
      this.label224.TabIndex = 169;
      this.label224.Text = "0";
      // 
      // tb_PITCH_TOTAL_GAIN
      // 
      this.tb_PITCH_TOTAL_GAIN.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_TOTAL_GAIN.LargeChange = 10;
      this.tb_PITCH_TOTAL_GAIN.Location = new System.Drawing.Point(13, 83);
      this.tb_PITCH_TOTAL_GAIN.Maximum = 100;
      this.tb_PITCH_TOTAL_GAIN.Name = "tb_PITCH_TOTAL_GAIN";
      this.tb_PITCH_TOTAL_GAIN.Size = new System.Drawing.Size(400, 45);
      this.tb_PITCH_TOTAL_GAIN.TabIndex = 153;
      this.tb_PITCH_TOTAL_GAIN.TickFrequency = 5;
      this.tb_PITCH_TOTAL_GAIN.Scroll += new System.EventHandler(this.tb_PITCH_TOTAL_GAIN_Scroll);
      this.tb_PITCH_TOTAL_GAIN.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // tb_PITCH_PWM_MAX
      // 
      this.tb_PITCH_PWM_MAX.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.tb_PITCH_PWM_MAX.LargeChange = 10;
      this.tb_PITCH_PWM_MAX.Location = new System.Drawing.Point(585, 21);
      this.tb_PITCH_PWM_MAX.Maximum = 255;
      this.tb_PITCH_PWM_MAX.Name = "tb_PITCH_PWM_MAX";
      this.tb_PITCH_PWM_MAX.Size = new System.Drawing.Size(250, 45);
      this.tb_PITCH_PWM_MAX.TabIndex = 152;
      this.tb_PITCH_PWM_MAX.TickFrequency = 15;
      this.tb_PITCH_PWM_MAX.Scroll += new System.EventHandler(this.tb_PITCH_PWM_MAX_Scroll);
      this.tb_PITCH_PWM_MAX.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
      // 
      // groupBox3
      // 
      this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
      this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.groupBox3.Controls.Add(this.btSettingsClearEeprom);
      this.groupBox3.Controls.Add(this.btSettingsWriteToEEProm);
      this.groupBox3.Controls.Add(this.btSettingsWriteToYoke);
      this.groupBox3.Controls.Add(this.btSettingsReadFromYoke);
      this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.groupBox3.Location = new System.Drawing.Point(879, 32);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(156, 603);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      // 
      // btSettingsClearEeprom
      // 
      this.btSettingsClearEeprom.Enabled = false;
      this.btSettingsClearEeprom.Location = new System.Drawing.Point(9, 101);
      this.btSettingsClearEeprom.Name = "btSettingsClearEeprom";
      this.btSettingsClearEeprom.Size = new System.Drawing.Size(137, 23);
      this.btSettingsClearEeprom.TabIndex = 203;
      this.btSettingsClearEeprom.Text = "Clear EEProm";
      this.mainToolTip.SetToolTip(this.btSettingsClearEeprom, "Clear EEPROM Data of Yoke, Defauls will be loaded on restart");
      this.btSettingsClearEeprom.UseVisualStyleBackColor = true;
      this.btSettingsClearEeprom.Click += new System.EventHandler(this.btSettingsClearEeprom_Click);
      // 
      // btSettingsWriteToEEProm
      // 
      this.btSettingsWriteToEEProm.Enabled = false;
      this.btSettingsWriteToEEProm.Location = new System.Drawing.Point(9, 72);
      this.btSettingsWriteToEEProm.Name = "btSettingsWriteToEEProm";
      this.btSettingsWriteToEEProm.Size = new System.Drawing.Size(137, 23);
      this.btSettingsWriteToEEProm.TabIndex = 202;
      this.btSettingsWriteToEEProm.Text = "Save to EEProm";
      this.mainToolTip.SetToolTip(this.btSettingsWriteToEEProm, "Save transmitted Settings to EEPROM");
      this.btSettingsWriteToEEProm.UseVisualStyleBackColor = true;
      this.btSettingsWriteToEEProm.Click += new System.EventHandler(this.btSettingsWriteToEEProm_Click);
      // 
      // btSettingsWriteToYoke
      // 
      this.btSettingsWriteToYoke.Enabled = false;
      this.btSettingsWriteToYoke.Location = new System.Drawing.Point(9, 43);
      this.btSettingsWriteToYoke.Name = "btSettingsWriteToYoke";
      this.btSettingsWriteToYoke.Size = new System.Drawing.Size(137, 23);
      this.btSettingsWriteToYoke.TabIndex = 201;
      this.btSettingsWriteToYoke.Text = "Write to Yoke";
      this.mainToolTip.SetToolTip(this.btSettingsWriteToYoke, "Write Settings to Yoke");
      this.btSettingsWriteToYoke.UseVisualStyleBackColor = true;
      this.btSettingsWriteToYoke.Click += new System.EventHandler(this.btSettingsWriteToYoke_Click);
      // 
      // btSettingsReadFromYoke
      // 
      this.btSettingsReadFromYoke.Enabled = false;
      this.btSettingsReadFromYoke.Location = new System.Drawing.Point(9, 15);
      this.btSettingsReadFromYoke.Name = "btSettingsReadFromYoke";
      this.btSettingsReadFromYoke.Size = new System.Drawing.Size(137, 23);
      this.btSettingsReadFromYoke.TabIndex = 200;
      this.btSettingsReadFromYoke.Text = "Read from Yoke";
      this.mainToolTip.SetToolTip(this.btSettingsReadFromYoke, "Read Settinfs from Yoke");
      this.btSettingsReadFromYoke.UseVisualStyleBackColor = true;
      this.btSettingsReadFromYoke.Click += new System.EventHandler(this.btSettingsReadFromYoke_Click);
      // 
      // tabPageMainDebug
      // 
      this.tabPageMainDebug.Controls.Add(this.btDebugStop);
      this.tabPageMainDebug.Controls.Add(this.btDebugStart);
      this.tabPageMainDebug.Controls.Add(this.tabControlDebug);
      this.tabPageMainDebug.Location = new System.Drawing.Point(4, 22);
      this.tabPageMainDebug.Name = "tabPageMainDebug";
      this.tabPageMainDebug.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMainDebug.Size = new System.Drawing.Size(1048, 649);
      this.tabPageMainDebug.TabIndex = 1;
      this.tabPageMainDebug.Text = "Debug";
      this.tabPageMainDebug.UseVisualStyleBackColor = true;
      // 
      // btDebugStop
      // 
      this.btDebugStop.Enabled = false;
      this.btDebugStop.Location = new System.Drawing.Point(129, 11);
      this.btDebugStop.Name = "btDebugStop";
      this.btDebugStop.Size = new System.Drawing.Size(120, 23);
      this.btDebugStop.TabIndex = 7;
      this.btDebugStop.Text = "Stop";
      this.mainToolTip.SetToolTip(this.btDebugStop, "Stop debug");
      this.btDebugStop.UseVisualStyleBackColor = true;
      this.btDebugStop.Click += new System.EventHandler(this.btDebugStop_Click);
      // 
      // btDebugStart
      // 
      this.btDebugStart.Enabled = false;
      this.btDebugStart.Location = new System.Drawing.Point(3, 11);
      this.btDebugStart.Name = "btDebugStart";
      this.btDebugStart.Size = new System.Drawing.Size(120, 23);
      this.btDebugStart.TabIndex = 6;
      this.btDebugStart.Text = "Start";
      this.mainToolTip.SetToolTip(this.btDebugStart, "Start debug and read data every 1 Second");
      this.btDebugStart.UseVisualStyleBackColor = true;
      this.btDebugStart.Click += new System.EventHandler(this.btDebugStart_Click);
      // 
      // tabControlDebug
      // 
      this.tabControlDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControlDebug.Controls.Add(this.tabButtons);
      this.tabControlDebug.Controls.Add(this.tabRoll);
      this.tabControlDebug.Controls.Add(this.tabPitch);
      this.tabControlDebug.Location = new System.Drawing.Point(3, 40);
      this.tabControlDebug.Name = "tabControlDebug";
      this.tabControlDebug.SelectedIndex = 0;
      this.tabControlDebug.Size = new System.Drawing.Size(1042, 606);
      this.tabControlDebug.TabIndex = 5;
      // 
      // tabButtons
      // 
      this.tabButtons.AutoScroll = true;
      this.tabButtons.BackColor = System.Drawing.Color.Gray;
      this.tabButtons.Controls.Add(this.label229);
      this.tabButtons.Controls.Add(this.tb_sensor_left_green);
      this.tabButtons.Controls.Add(this.tb_sensor_left_black);
      this.tabButtons.Controls.Add(this.label228);
      this.tabButtons.Controls.Add(this.tb_sensor_right_green);
      this.tabButtons.Controls.Add(this.tb_sensor_right_black);
      this.tabButtons.Controls.Add(this.label227);
      this.tabButtons.Controls.Add(this.tb_sensor_up_green);
      this.tabButtons.Controls.Add(this.tb_sensor_up_black);
      this.tabButtons.Controls.Add(this.label226);
      this.tabButtons.Controls.Add(this.tb_sensor_down_green);
      this.tabButtons.Controls.Add(this.tb_sensor_down_black);
      this.tabButtons.Controls.Add(this.label225);
      this.tabButtons.Controls.Add(this.tb_button_calibration_green);
      this.tabButtons.Controls.Add(this.tb_button_calibration_black);
      this.tabButtons.Controls.Add(this.cb_yoke_7);
      this.tabButtons.Controls.Add(this.cb_yoke_13);
      this.tabButtons.Controls.Add(this.cb_yoke_15);
      this.tabButtons.Controls.Add(this.cb_yoke_14);
      this.tabButtons.Controls.Add(this.cb_yoke_12);
      this.tabButtons.Controls.Add(this.cb_yoke_11);
      this.tabButtons.Controls.Add(this.cb_yoke_10);
      this.tabButtons.Controls.Add(this.cb_yoke_3);
      this.tabButtons.Controls.Add(this.cb_yoke_2);
      this.tabButtons.Controls.Add(this.cb_yoke_0);
      this.tabButtons.Controls.Add(this.cb_yoke_1);
      this.tabButtons.Controls.Add(this.cb_yoke_4);
      this.tabButtons.Controls.Add(this.cb_yoke_9);
      this.tabButtons.Controls.Add(this.cb_yoke_6);
      this.tabButtons.Controls.Add(this.cb_yoke_5);
      this.tabButtons.Controls.Add(this.cb_yoke_8);
      this.tabButtons.Controls.Add(this.pbDebugYoke);
      this.tabButtons.Location = new System.Drawing.Point(4, 22);
      this.tabButtons.Name = "tabButtons";
      this.tabButtons.Padding = new System.Windows.Forms.Padding(3);
      this.tabButtons.Size = new System.Drawing.Size(1034, 580);
      this.tabButtons.TabIndex = 0;
      this.tabButtons.Text = "Buttons";
      // 
      // label229
      // 
      this.label229.AutoSize = true;
      this.label229.BackColor = System.Drawing.Color.Transparent;
      this.label229.Location = new System.Drawing.Point(903, 324);
      this.label229.Name = "label229";
      this.label229.Size = new System.Drawing.Size(61, 13);
      this.label229.TabIndex = 31;
      this.label229.Text = "Left Sensor";
      // 
      // tb_sensor_left_green
      // 
      this.tb_sensor_left_green.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_left_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_left_green.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_left_green.Image")));
      this.tb_sensor_left_green.Location = new System.Drawing.Point(970, 310);
      this.tb_sensor_left_green.Name = "tb_sensor_left_green";
      this.tb_sensor_left_green.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_left_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_left_green.TabIndex = 30;
      this.tb_sensor_left_green.TabStop = false;
      this.tb_sensor_left_green.Visible = false;
      // 
      // tb_sensor_left_black
      // 
      this.tb_sensor_left_black.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_left_black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_left_black.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_left_black.Image")));
      this.tb_sensor_left_black.Location = new System.Drawing.Point(970, 310);
      this.tb_sensor_left_black.Name = "tb_sensor_left_black";
      this.tb_sensor_left_black.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_left_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_left_black.TabIndex = 29;
      this.tb_sensor_left_black.TabStop = false;
      // 
      // label228
      // 
      this.label228.AutoSize = true;
      this.label228.BackColor = System.Drawing.Color.Transparent;
      this.label228.Location = new System.Drawing.Point(896, 374);
      this.label228.Name = "label228";
      this.label228.Size = new System.Drawing.Size(68, 13);
      this.label228.TabIndex = 28;
      this.label228.Text = "Right Sensor";
      // 
      // tb_sensor_right_green
      // 
      this.tb_sensor_right_green.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_right_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_right_green.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_right_green.Image")));
      this.tb_sensor_right_green.Location = new System.Drawing.Point(970, 358);
      this.tb_sensor_right_green.Name = "tb_sensor_right_green";
      this.tb_sensor_right_green.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_right_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_right_green.TabIndex = 27;
      this.tb_sensor_right_green.TabStop = false;
      this.tb_sensor_right_green.Visible = false;
      // 
      // tb_sensor_right_black
      // 
      this.tb_sensor_right_black.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_right_black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_right_black.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_right_black.Image")));
      this.tb_sensor_right_black.Location = new System.Drawing.Point(970, 358);
      this.tb_sensor_right_black.Name = "tb_sensor_right_black";
      this.tb_sensor_right_black.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_right_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_right_black.TabIndex = 26;
      this.tb_sensor_right_black.TabStop = false;
      // 
      // label227
      // 
      this.label227.AutoSize = true;
      this.label227.BackColor = System.Drawing.Color.Transparent;
      this.label227.Location = new System.Drawing.Point(907, 421);
      this.label227.Name = "label227";
      this.label227.Size = new System.Drawing.Size(57, 13);
      this.label227.TabIndex = 25;
      this.label227.Text = "Up Sensor";
      // 
      // tb_sensor_up_green
      // 
      this.tb_sensor_up_green.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_up_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_up_green.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_up_green.Image")));
      this.tb_sensor_up_green.Location = new System.Drawing.Point(970, 406);
      this.tb_sensor_up_green.Name = "tb_sensor_up_green";
      this.tb_sensor_up_green.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_up_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_up_green.TabIndex = 24;
      this.tb_sensor_up_green.TabStop = false;
      this.tb_sensor_up_green.Visible = false;
      // 
      // tb_sensor_up_black
      // 
      this.tb_sensor_up_black.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_up_black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_up_black.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_up_black.Image")));
      this.tb_sensor_up_black.Location = new System.Drawing.Point(970, 406);
      this.tb_sensor_up_black.Name = "tb_sensor_up_black";
      this.tb_sensor_up_black.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_up_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_up_black.TabIndex = 23;
      this.tb_sensor_up_black.TabStop = false;
      // 
      // label226
      // 
      this.label226.AutoSize = true;
      this.label226.BackColor = System.Drawing.Color.Transparent;
      this.label226.Location = new System.Drawing.Point(893, 469);
      this.label226.Name = "label226";
      this.label226.Size = new System.Drawing.Size(71, 13);
      this.label226.TabIndex = 22;
      this.label226.Text = "Down Sensor";
      // 
      // tb_sensor_down_green
      // 
      this.tb_sensor_down_green.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_down_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_down_green.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_down_green.Image")));
      this.tb_sensor_down_green.Location = new System.Drawing.Point(970, 454);
      this.tb_sensor_down_green.Name = "tb_sensor_down_green";
      this.tb_sensor_down_green.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_down_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_down_green.TabIndex = 21;
      this.tb_sensor_down_green.TabStop = false;
      this.tb_sensor_down_green.Visible = false;
      // 
      // tb_sensor_down_black
      // 
      this.tb_sensor_down_black.BackColor = System.Drawing.Color.Transparent;
      this.tb_sensor_down_black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_sensor_down_black.Image = ((System.Drawing.Image)(resources.GetObject("tb_sensor_down_black.Image")));
      this.tb_sensor_down_black.Location = new System.Drawing.Point(970, 454);
      this.tb_sensor_down_black.Name = "tb_sensor_down_black";
      this.tb_sensor_down_black.Size = new System.Drawing.Size(42, 42);
      this.tb_sensor_down_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_sensor_down_black.TabIndex = 20;
      this.tb_sensor_down_black.TabStop = false;
      // 
      // label225
      // 
      this.label225.AutoSize = true;
      this.label225.BackColor = System.Drawing.Color.Transparent;
      this.label225.Location = new System.Drawing.Point(874, 518);
      this.label225.Name = "label225";
      this.label225.Size = new System.Drawing.Size(90, 13);
      this.label225.TabIndex = 19;
      this.label225.Text = "Calibration Button";
      // 
      // tb_button_calibration_green
      // 
      this.tb_button_calibration_green.BackColor = System.Drawing.Color.Transparent;
      this.tb_button_calibration_green.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_button_calibration_green.Image = ((System.Drawing.Image)(resources.GetObject("tb_button_calibration_green.Image")));
      this.tb_button_calibration_green.Location = new System.Drawing.Point(970, 502);
      this.tb_button_calibration_green.Name = "tb_button_calibration_green";
      this.tb_button_calibration_green.Size = new System.Drawing.Size(42, 42);
      this.tb_button_calibration_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_button_calibration_green.TabIndex = 18;
      this.tb_button_calibration_green.TabStop = false;
      this.tb_button_calibration_green.Visible = false;
      // 
      // tb_button_calibration_black
      // 
      this.tb_button_calibration_black.BackColor = System.Drawing.Color.Transparent;
      this.tb_button_calibration_black.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tb_button_calibration_black.Image = ((System.Drawing.Image)(resources.GetObject("tb_button_calibration_black.Image")));
      this.tb_button_calibration_black.Location = new System.Drawing.Point(970, 502);
      this.tb_button_calibration_black.Name = "tb_button_calibration_black";
      this.tb_button_calibration_black.Size = new System.Drawing.Size(42, 42);
      this.tb_button_calibration_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.tb_button_calibration_black.TabIndex = 17;
      this.tb_button_calibration_black.TabStop = false;
      // 
      // cb_yoke_7
      // 
      this.cb_yoke_7.AutoSize = true;
      this.cb_yoke_7.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_7.Enabled = false;
      this.cb_yoke_7.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_7.Location = new System.Drawing.Point(298, 167);
      this.cb_yoke_7.Name = "cb_yoke_7";
      this.cb_yoke_7.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_7.TabIndex = 16;
      this.cb_yoke_7.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_13
      // 
      this.cb_yoke_13.AutoSize = true;
      this.cb_yoke_13.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_13.Enabled = false;
      this.cb_yoke_13.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_13.Location = new System.Drawing.Point(693, 167);
      this.cb_yoke_13.Name = "cb_yoke_13";
      this.cb_yoke_13.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_13.TabIndex = 15;
      this.cb_yoke_13.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_15
      // 
      this.cb_yoke_15.AutoSize = true;
      this.cb_yoke_15.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_15.Enabled = false;
      this.cb_yoke_15.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_15.Location = new System.Drawing.Point(777, 164);
      this.cb_yoke_15.Name = "cb_yoke_15";
      this.cb_yoke_15.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_15.TabIndex = 14;
      this.cb_yoke_15.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_14
      // 
      this.cb_yoke_14.AutoSize = true;
      this.cb_yoke_14.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_14.Enabled = false;
      this.cb_yoke_14.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_14.Location = new System.Drawing.Point(774, 142);
      this.cb_yoke_14.Name = "cb_yoke_14";
      this.cb_yoke_14.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_14.TabIndex = 13;
      this.cb_yoke_14.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_12
      // 
      this.cb_yoke_12.AutoSize = true;
      this.cb_yoke_12.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_12.Enabled = false;
      this.cb_yoke_12.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_12.Location = new System.Drawing.Point(790, 126);
      this.cb_yoke_12.Name = "cb_yoke_12";
      this.cb_yoke_12.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_12.TabIndex = 12;
      this.cb_yoke_12.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_11
      // 
      this.cb_yoke_11.AutoSize = true;
      this.cb_yoke_11.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_11.Enabled = false;
      this.cb_yoke_11.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_11.Location = new System.Drawing.Point(744, 129);
      this.cb_yoke_11.Name = "cb_yoke_11";
      this.cb_yoke_11.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_11.TabIndex = 11;
      this.cb_yoke_11.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_10
      // 
      this.cb_yoke_10.AutoSize = true;
      this.cb_yoke_10.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_10.Enabled = false;
      this.cb_yoke_10.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_10.Location = new System.Drawing.Point(752, 100);
      this.cb_yoke_10.Name = "cb_yoke_10";
      this.cb_yoke_10.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_10.TabIndex = 10;
      this.cb_yoke_10.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_3
      // 
      this.cb_yoke_3.AutoSize = true;
      this.cb_yoke_3.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_3.Enabled = false;
      this.cb_yoke_3.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_3.Location = new System.Drawing.Point(216, 90);
      this.cb_yoke_3.Name = "cb_yoke_3";
      this.cb_yoke_3.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_3.TabIndex = 9;
      this.cb_yoke_3.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_2
      // 
      this.cb_yoke_2.AutoSize = true;
      this.cb_yoke_2.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_2.Enabled = false;
      this.cb_yoke_2.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_2.Location = new System.Drawing.Point(237, 70);
      this.cb_yoke_2.Name = "cb_yoke_2";
      this.cb_yoke_2.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_2.TabIndex = 8;
      this.cb_yoke_2.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_0
      // 
      this.cb_yoke_0.AutoSize = true;
      this.cb_yoke_0.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_0.Enabled = false;
      this.cb_yoke_0.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_0.Location = new System.Drawing.Point(258, 90);
      this.cb_yoke_0.Name = "cb_yoke_0";
      this.cb_yoke_0.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_0.TabIndex = 7;
      this.cb_yoke_0.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_1
      // 
      this.cb_yoke_1.AutoSize = true;
      this.cb_yoke_1.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_1.Enabled = false;
      this.cb_yoke_1.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_1.Location = new System.Drawing.Point(237, 110);
      this.cb_yoke_1.Name = "cb_yoke_1";
      this.cb_yoke_1.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_1.TabIndex = 6;
      this.cb_yoke_1.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_4
      // 
      this.cb_yoke_4.AutoSize = true;
      this.cb_yoke_4.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_4.Enabled = false;
      this.cb_yoke_4.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_4.Location = new System.Drawing.Point(237, 90);
      this.cb_yoke_4.Name = "cb_yoke_4";
      this.cb_yoke_4.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_4.TabIndex = 5;
      this.cb_yoke_4.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_9
      // 
      this.cb_yoke_9.AutoSize = true;
      this.cb_yoke_9.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_9.Enabled = false;
      this.cb_yoke_9.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_9.Location = new System.Drawing.Point(197, 150);
      this.cb_yoke_9.Name = "cb_yoke_9";
      this.cb_yoke_9.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_9.TabIndex = 4;
      this.cb_yoke_9.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_6
      // 
      this.cb_yoke_6.AutoSize = true;
      this.cb_yoke_6.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_6.Enabled = false;
      this.cb_yoke_6.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_6.Location = new System.Drawing.Point(237, 150);
      this.cb_yoke_6.Name = "cb_yoke_6";
      this.cb_yoke_6.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_6.TabIndex = 3;
      this.cb_yoke_6.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_5
      // 
      this.cb_yoke_5.AutoSize = true;
      this.cb_yoke_5.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_5.Enabled = false;
      this.cb_yoke_5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_5.Location = new System.Drawing.Point(248, 129);
      this.cb_yoke_5.Name = "cb_yoke_5";
      this.cb_yoke_5.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_5.TabIndex = 2;
      this.cb_yoke_5.UseVisualStyleBackColor = false;
      // 
      // cb_yoke_8
      // 
      this.cb_yoke_8.AutoSize = true;
      this.cb_yoke_8.BackColor = System.Drawing.Color.Gray;
      this.cb_yoke_8.Enabled = false;
      this.cb_yoke_8.ForeColor = System.Drawing.SystemColors.ControlText;
      this.cb_yoke_8.Location = new System.Drawing.Point(202, 125);
      this.cb_yoke_8.Name = "cb_yoke_8";
      this.cb_yoke_8.Size = new System.Drawing.Size(15, 14);
      this.cb_yoke_8.TabIndex = 1;
      this.cb_yoke_8.UseVisualStyleBackColor = false;
      // 
      // pbDebugYoke
      // 
      this.pbDebugYoke.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pbDebugYoke.BackColor = System.Drawing.Color.Transparent;
      this.pbDebugYoke.Image = ((System.Drawing.Image)(resources.GetObject("pbDebugYoke.Image")));
      this.pbDebugYoke.Location = new System.Drawing.Point(6, 6);
      this.pbDebugYoke.Name = "pbDebugYoke";
      this.pbDebugYoke.Size = new System.Drawing.Size(1022, 566);
      this.pbDebugYoke.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbDebugYoke.TabIndex = 0;
      this.pbDebugYoke.TabStop = false;
      // 
      // tabRoll
      // 
      this.tabRoll.AutoScroll = true;
      this.tabRoll.BackColor = System.Drawing.Color.Gray;
      this.tabRoll.Controls.Add(this.chart_FORCE_ROLL);
      this.tabRoll.Controls.Add(this.chart_COUNTER_ROLL);
      this.tabRoll.Controls.Add(this.chart_SPEED_ROLL);
      this.tabRoll.Location = new System.Drawing.Point(4, 22);
      this.tabRoll.Name = "tabRoll";
      this.tabRoll.Size = new System.Drawing.Size(1034, 580);
      this.tabRoll.TabIndex = 2;
      this.tabRoll.Text = "Roll";
      // 
      // chart_FORCE_ROLL
      // 
      chartArea1.AxisX.LabelStyle.Enabled = false;
      chartArea1.AxisX.Maximum = 60D;
      chartArea1.AxisX.Minimum = 1D;
      chartArea1.AxisY.Maximum = 32500D;
      chartArea1.AxisY.Minimum = -32500D;
      chartArea1.AxisY.Title = "Value: 0";
      chartArea1.Name = "ChartArea1";
      this.chart_FORCE_ROLL.ChartAreas.Add(chartArea1);
      this.chart_FORCE_ROLL.Enabled = false;
      legend1.Name = "Legend1";
      this.chart_FORCE_ROLL.Legends.Add(legend1);
      this.chart_FORCE_ROLL.Location = new System.Drawing.Point(3, 715);
      this.chart_FORCE_ROLL.Name = "chart_FORCE_ROLL";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series1.Color = System.Drawing.Color.Lime;
      series1.Legend = "Legend1";
      series1.LegendText = "Force";
      series1.Name = "Series1";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series2.Color = System.Drawing.Color.Red;
      series2.Legend = "Legend1";
      series2.LegendText = "Max";
      series2.Name = "Series2";
      series3.ChartArea = "ChartArea1";
      series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series3.Color = System.Drawing.Color.RoyalBlue;
      series3.Legend = "Legend1";
      series3.LegendText = "Min";
      series3.Name = "Series3";
      this.chart_FORCE_ROLL.Series.Add(series1);
      this.chart_FORCE_ROLL.Series.Add(series2);
      this.chart_FORCE_ROLL.Series.Add(series3);
      this.chart_FORCE_ROLL.Size = new System.Drawing.Size(970, 350);
      this.chart_FORCE_ROLL.TabIndex = 46;
      this.chart_FORCE_ROLL.Text = "Roll";
      title1.Name = "Title1";
      title1.Text = "Force Pitch";
      this.chart_FORCE_ROLL.Titles.Add(title1);
      // 
      // chart_COUNTER_ROLL
      // 
      chartArea2.AxisX.LabelStyle.Enabled = false;
      chartArea2.AxisX.Maximum = 60D;
      chartArea2.AxisX.Minimum = 1D;
      chartArea2.AxisY.Maximum = 256D;
      chartArea2.AxisY.Minimum = -256D;
      chartArea2.AxisY.Title = "Value: 0";
      chartArea2.Name = "ChartArea1";
      this.chart_COUNTER_ROLL.ChartAreas.Add(chartArea2);
      this.chart_COUNTER_ROLL.Enabled = false;
      legend2.Name = "Legend1";
      this.chart_COUNTER_ROLL.Legends.Add(legend2);
      this.chart_COUNTER_ROLL.Location = new System.Drawing.Point(3, 3);
      this.chart_COUNTER_ROLL.Name = "chart_COUNTER_ROLL";
      series4.ChartArea = "ChartArea1";
      series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series4.Color = System.Drawing.Color.Lime;
      series4.Legend = "Legend1";
      series4.LegendText = "Counter";
      series4.Name = "Series1";
      series5.ChartArea = "ChartArea1";
      series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series5.Color = System.Drawing.Color.Red;
      series5.Legend = "Legend1";
      series5.LegendText = "Calibr. Max";
      series5.Name = "Series2";
      series6.ChartArea = "ChartArea1";
      series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series6.Color = System.Drawing.Color.RoyalBlue;
      series6.Legend = "Legend1";
      series6.LegendText = "Calibr. Min";
      series6.Name = "Series3";
      this.chart_COUNTER_ROLL.Series.Add(series4);
      this.chart_COUNTER_ROLL.Series.Add(series5);
      this.chart_COUNTER_ROLL.Series.Add(series6);
      this.chart_COUNTER_ROLL.Size = new System.Drawing.Size(970, 350);
      this.chart_COUNTER_ROLL.TabIndex = 36;
      this.chart_COUNTER_ROLL.Text = "Roll";
      title2.Name = "Title1";
      title2.Text = "Counter Roll";
      this.chart_COUNTER_ROLL.Titles.Add(title2);
      // 
      // chart_SPEED_ROLL
      // 
      chartArea3.AxisX.LabelStyle.Enabled = false;
      chartArea3.AxisX.Maximum = 60D;
      chartArea3.AxisX.Minimum = 1D;
      chartArea3.AxisY.Maximum = 255D;
      chartArea3.AxisY.Minimum = 0D;
      chartArea3.AxisY.Title = "Value: 0";
      chartArea3.Name = "ChartArea1";
      this.chart_SPEED_ROLL.ChartAreas.Add(chartArea3);
      this.chart_SPEED_ROLL.Enabled = false;
      legend3.Name = "Legend1";
      this.chart_SPEED_ROLL.Legends.Add(legend3);
      this.chart_SPEED_ROLL.Location = new System.Drawing.Point(3, 359);
      this.chart_SPEED_ROLL.Name = "chart_SPEED_ROLL";
      series7.ChartArea = "ChartArea1";
      series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series7.Color = System.Drawing.Color.Lime;
      series7.Legend = "Legend1";
      series7.LegendText = "Speed";
      series7.Name = "Series1";
      series8.ChartArea = "ChartArea1";
      series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series8.Color = System.Drawing.Color.Red;
      series8.Legend = "Legend1";
      series8.LegendText = "Max PWM";
      series8.Name = "Series2";
      series9.ChartArea = "ChartArea1";
      series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series9.Color = System.Drawing.Color.RoyalBlue;
      series9.Legend = "Legend1";
      series9.LegendText = "Min PWM";
      series9.Name = "Series3";
      this.chart_SPEED_ROLL.Series.Add(series7);
      this.chart_SPEED_ROLL.Series.Add(series8);
      this.chart_SPEED_ROLL.Series.Add(series9);
      this.chart_SPEED_ROLL.Size = new System.Drawing.Size(970, 350);
      this.chart_SPEED_ROLL.TabIndex = 34;
      this.chart_SPEED_ROLL.Text = "Roll";
      title3.Name = "Title1";
      title3.Text = "Speed Roll (PWM)";
      this.chart_SPEED_ROLL.Titles.Add(title3);
      // 
      // tabPitch
      // 
      this.tabPitch.AutoScroll = true;
      this.tabPitch.BackColor = System.Drawing.Color.Gray;
      this.tabPitch.Controls.Add(this.chart_FORCE_PITCH);
      this.tabPitch.Controls.Add(this.chart_COUNTER_PITCH);
      this.tabPitch.Controls.Add(this.chart_SPEED_PITCH);
      this.tabPitch.Location = new System.Drawing.Point(4, 22);
      this.tabPitch.Name = "tabPitch";
      this.tabPitch.Size = new System.Drawing.Size(1034, 580);
      this.tabPitch.TabIndex = 3;
      this.tabPitch.Text = "Pitch";
      // 
      // chart_FORCE_PITCH
      // 
      chartArea4.AxisX.LabelStyle.Enabled = false;
      chartArea4.AxisX.Maximum = 60D;
      chartArea4.AxisX.Minimum = 1D;
      chartArea4.AxisY.Maximum = 32500D;
      chartArea4.AxisY.Minimum = -32500D;
      chartArea4.AxisY.Title = "Value: 0";
      chartArea4.Name = "ChartArea1";
      this.chart_FORCE_PITCH.ChartAreas.Add(chartArea4);
      this.chart_FORCE_PITCH.Enabled = false;
      legend4.Name = "Legend1";
      this.chart_FORCE_PITCH.Legends.Add(legend4);
      this.chart_FORCE_PITCH.Location = new System.Drawing.Point(3, 715);
      this.chart_FORCE_PITCH.Name = "chart_FORCE_PITCH";
      series10.ChartArea = "ChartArea1";
      series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series10.Color = System.Drawing.Color.Lime;
      series10.Legend = "Legend1";
      series10.LegendText = "Force";
      series10.Name = "Series1";
      series11.ChartArea = "ChartArea1";
      series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series11.Color = System.Drawing.Color.Red;
      series11.Legend = "Legend1";
      series11.LegendText = "Max";
      series11.Name = "Series2";
      series12.ChartArea = "ChartArea1";
      series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series12.Color = System.Drawing.Color.RoyalBlue;
      series12.Legend = "Legend1";
      series12.LegendText = "Min";
      series12.Name = "Series3";
      this.chart_FORCE_PITCH.Series.Add(series10);
      this.chart_FORCE_PITCH.Series.Add(series11);
      this.chart_FORCE_PITCH.Series.Add(series12);
      this.chart_FORCE_PITCH.Size = new System.Drawing.Size(970, 350);
      this.chart_FORCE_PITCH.TabIndex = 45;
      this.chart_FORCE_PITCH.Text = "Roll";
      title4.Name = "Title1";
      title4.Text = "Force Pitch";
      this.chart_FORCE_PITCH.Titles.Add(title4);
      // 
      // chart_COUNTER_PITCH
      // 
      chartArea5.AxisX.LabelStyle.Enabled = false;
      chartArea5.AxisX.Maximum = 60D;
      chartArea5.AxisX.Minimum = 1D;
      chartArea5.AxisY.Maximum = 256D;
      chartArea5.AxisY.Minimum = -256D;
      chartArea5.AxisY.Title = "Value: 0";
      chartArea5.Name = "ChartArea1";
      this.chart_COUNTER_PITCH.ChartAreas.Add(chartArea5);
      this.chart_COUNTER_PITCH.Enabled = false;
      legend5.Name = "Legend1";
      this.chart_COUNTER_PITCH.Legends.Add(legend5);
      this.chart_COUNTER_PITCH.Location = new System.Drawing.Point(3, 3);
      this.chart_COUNTER_PITCH.Name = "chart_COUNTER_PITCH";
      series13.ChartArea = "ChartArea1";
      series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series13.Color = System.Drawing.Color.Lime;
      series13.Legend = "Legend1";
      series13.LegendText = "Counter";
      series13.Name = "Series1";
      series14.ChartArea = "ChartArea1";
      series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series14.Color = System.Drawing.Color.Red;
      series14.Legend = "Legend1";
      series14.LegendText = "Calibr. Max";
      series14.Name = "Series2";
      series15.ChartArea = "ChartArea1";
      series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series15.Color = System.Drawing.Color.RoyalBlue;
      series15.Legend = "Legend1";
      series15.LegendText = "Calibr. Min";
      series15.Name = "Series3";
      this.chart_COUNTER_PITCH.Series.Add(series13);
      this.chart_COUNTER_PITCH.Series.Add(series14);
      this.chart_COUNTER_PITCH.Series.Add(series15);
      this.chart_COUNTER_PITCH.Size = new System.Drawing.Size(970, 350);
      this.chart_COUNTER_PITCH.TabIndex = 44;
      this.chart_COUNTER_PITCH.Text = "Roll";
      title5.Name = "Title1";
      title5.Text = "Counter Roll";
      this.chart_COUNTER_PITCH.Titles.Add(title5);
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
      this.chart_SPEED_PITCH.Enabled = false;
      legend6.Name = "Legend1";
      this.chart_SPEED_PITCH.Legends.Add(legend6);
      this.chart_SPEED_PITCH.Location = new System.Drawing.Point(3, 359);
      this.chart_SPEED_PITCH.Name = "chart_SPEED_PITCH";
      series16.ChartArea = "ChartArea1";
      series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series16.Color = System.Drawing.Color.Lime;
      series16.Legend = "Legend1";
      series16.LegendText = "Speed";
      series16.Name = "Series1";
      series17.ChartArea = "ChartArea1";
      series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series17.Color = System.Drawing.Color.Red;
      series17.Legend = "Legend1";
      series17.LegendText = "Max PWM";
      series17.Name = "Series2";
      series18.ChartArea = "ChartArea1";
      series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
      series18.Color = System.Drawing.Color.RoyalBlue;
      series18.Legend = "Legend1";
      series18.LegendText = "Min PWM";
      series18.Name = "Series3";
      this.chart_SPEED_PITCH.Series.Add(series16);
      this.chart_SPEED_PITCH.Series.Add(series17);
      this.chart_SPEED_PITCH.Series.Add(series18);
      this.chart_SPEED_PITCH.Size = new System.Drawing.Size(970, 350);
      this.chart_SPEED_PITCH.TabIndex = 43;
      this.chart_SPEED_PITCH.Text = "Roll";
      title6.Name = "Title1";
      title6.Text = "Speed Pitch (PWM)";
      this.chart_SPEED_PITCH.Titles.Add(title6);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.lbStatus});
      this.statusStrip1.Location = new System.Drawing.Point(0, 746);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
      this.statusStrip1.SizingGrip = false;
      this.statusStrip1.TabIndex = 10;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripProgressBar1
      // 
      this.toolStripProgressBar1.Name = "toolStripProgressBar1";
      this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
      // 
      // lbStatus
      // 
      this.lbStatus.Name = "lbStatus";
      this.lbStatus.Size = new System.Drawing.Size(0, 17);
      // 
      // mainMenu
      // 
      this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Size = new System.Drawing.Size(1060, 24);
      this.mainMenu.TabIndex = 11;
      this.mainMenu.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(94, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.quitToolStripMenuItem.Text = "Quit";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.websiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // websiteToolStripMenuItem
      // 
      this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
      this.websiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.websiteToolStripMenuItem.Text = "Website";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
      this.aboutToolStripMenuItem.Text = "About";
      // 
      // timerReplySettingsTimeout
      // 
      this.timerReplySettingsTimeout.Interval = 30000;
      this.timerReplySettingsTimeout.Tick += new System.EventHandler(this.timerReplySettingsTimeout_Tick);
      // 
      // Mainform
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1060, 768);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.mainMenu);
      this.Controls.Add(this.tabControlMain);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mainMenu;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Mainform";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Arduino FFB Yoke App V1.3.0";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
      this.Load += new System.EventHandler(this.Mainform_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.tabControlMain.ResumeLayout(false);
      this.tabPageMainSettings.ResumeLayout(false);
      this.tabControlMainSettings.ResumeLayout(false);
      this.tabPageMainSettingsRoll.ResumeLayout(false);
      this.tabPageMainSettingsRoll.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_PWM_MIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_FORCE_MAX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_DAMPER_MAX_VELOCITY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_INERTIA_MAX_ACCELERATION)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_FRICTION_MAX_POSITION_CHANGE)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_FRICTION_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_INERTIA_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_DAMPER_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SPRING_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SAWTOOTH_UP_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SAWTOOT_DOWN_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_TRIANGLE_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SIN_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_SQUARE_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_RAMP_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_CONSTANT_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_TOTAL_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_ROLL_PWM_MAX)).EndInit();
      this.tabPageMainSettingsPitch.ResumeLayout(false);
      this.tabPageMainSettingsPitch.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_PWM_MIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_FORCE_MAX)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_DAMPER_MAX_VELOCITY)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_INERTIA_MAX_ACCELERATION)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_FRICTION_MAX_POSITION_CHANGE)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_FRICTION_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_INERTIA_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_DAMPER_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SPRING_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SAWTOOTH_UP_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SAWTOOT_DOWN_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_TRIANGLE_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SIN_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_SQUARE_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_RAMP_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_CONSTANT_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_TOTAL_GAIN)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_PITCH_PWM_MAX)).EndInit();
      this.groupBox3.ResumeLayout(false);
      this.tabPageMainDebug.ResumeLayout(false);
      this.tabControlDebug.ResumeLayout(false);
      this.tabButtons.ResumeLayout(false);
      this.tabButtons.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_left_green)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_left_black)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_right_green)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_right_black)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_up_green)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_up_black)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_down_green)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_sensor_down_black)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_button_calibration_green)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.tb_button_calibration_black)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbDebugYoke)).EndInit();
      this.tabRoll.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_ROLL)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_COUNTER_ROLL)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_ROLL)).EndInit();
      this.tabPitch.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart_FORCE_PITCH)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_COUNTER_PITCH)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart_SPEED_PITCH)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private GroupBox groupBox1;
    private ComboBox cbAvailablePortsBox;
    private Button btRefreshPortList;
    private Button btConnectToPort;


    private ToolTip mainToolTip;
    private TabControl tabControlMain;
    private TabPage tabPageMainSettings;
    private TabControl tabControlMainSettings;
    private TabPage tabPageMainSettingsRoll;
    private Label lb_ROLL_PWM_MAX;
    private TrackBar tb_ROLL_PWM_MAX;
    private Label lb_ROLL_PWM_MIN;
    private TrackBar tb_ROLL_PWM_MIN;
    private Label lb_ROLL_FORCE_MAX;
    private TrackBar tb_ROLL_FORCE_MAX;
    private Label label61;
    private Label label62;
    private Label label63;
    private Label label64;
    private Label label65;
    private Label lb_ROLL_DAMPER_MAX_VELOCITY;
    private TrackBar tb_ROLL_DAMPER_MAX_VELOCITY;
    private Label lb_ROLL_INERTIA_MAX_ACCELERATION;
    private Label label68;
    private Label label69;
    private Label label70;
    private Label label71;
    private Label label72;
    private TrackBar tb_ROLL_INERTIA_MAX_ACCELERATION;
    private Label label73;
    private Label label74;
    private Label label75;
    private Label label76;
    private Label label77;
    private Label lb_ROLL_FRICTION_MAX_POSITION_CHANGE;
    private TrackBar tb_ROLL_FRICTION_MAX_POSITION_CHANGE;
    private Label lb_ROLL_FRICTION_GAIN;
    private Label label80;
    private Label label81;
    private Label label82;
    private Label label83;
    private Label label84;
    private TrackBar tb_ROLL_FRICTION_GAIN;
    private Label lb_ROLL_INERTIA_GAIN;
    private Label label92;
    private Label label93;
    private Label label94;
    private Label label95;
    private Label label96;
    private TrackBar tb_ROLL_INERTIA_GAIN;
    private Label label97;
    private Label label98;
    private Label label99;
    private Label label100;
    private Label label101;
    private Label lb_ROLL_DAMPER_GAIN;
    private TrackBar tb_ROLL_DAMPER_GAIN;
    private Label lb_ROLL_SPRING_GAIN;
    private Label label104;
    private Label label105;
    private Label label106;
    private Label label107;
    private Label label108;
    private TrackBar tb_ROLL_SPRING_GAIN;
    private Label label37;
    private Label label38;
    private Label label39;
    private Label label40;
    private Label label41;
    private Label lb_ROLL_SAWTOOTH_UP_GAIN;
    private TrackBar tb_ROLL_SAWTOOTH_UP_GAIN;
    private Label lb_ROLL_SAWTOOT_DOWN_GAIN;
    private Label label44;
    private Label label45;
    private Label label46;
    private Label label47;
    private Label label48;
    private TrackBar tb_ROLL_SAWTOOT_DOWN_GAIN;
    private Label label49;
    private Label label50;
    private Label label51;
    private Label label52;
    private Label label53;
    private Label lb_ROLL_TRIANGLE_GAIN;
    private TrackBar tb_ROLL_TRIANGLE_GAIN;
    private Label lb_ROLL_SIN_GAIN;
    private Label label56;
    private Label label57;
    private Label label58;
    private Label label59;
    private Label label60;
    private TrackBar tb_ROLL_SIN_GAIN;
    private Label label16;
    private Label label21;
    private Label label22;
    private Label label23;
    private Label label24;
    private Label lb_ROLL_SQUARE_GAIN;
    private TrackBar tb_ROLL_SQUARE_GAIN;
    private Label lb_ROLL_RAMP_GAIN;
    private Label label32;
    private Label label33;
    private Label label34;
    private Label label35;
    private Label label36;
    private TrackBar tb_ROLL_RAMP_GAIN;
    private Label label25;
    private Label label26;
    private Label label27;
    private Label label28;
    private Label label29;
    private Label lb_ROLL_CONSTANT_GAIN;
    private TrackBar tb_ROLL_CONSTANT_GAIN;
    private Label lb_ROLL_TOTAL_GAIN;
    private Label label20;
    private Label label18;
    private Label label17;
    private Label label15;
    private Label label11;
    private TrackBar tb_ROLL_TOTAL_GAIN;
    private TabPage tabPageMainSettingsPitch;
    private GroupBox groupBox3;
    private Button btSettingsReadFromYoke;
    private TabPage tabPageMainDebug;
    private TabControl tabControlDebug;
    private TabPage tabButtons;
    private TabPage tabRoll;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_SPEED_ROLL;
    private TabPage tabPitch;
    private StatusStrip statusStrip1;
    private ToolStripProgressBar toolStripProgressBar1;
    private ToolStripStatusLabel lbStatus;
    private Button btSettingsWriteToYoke;
    private Button btSettingsWriteToEEProm;
    private Label label114;
    private Label label113;
    private Label label112;
    private Label label116;
    private Label label115;
    private Label label118;
    private Label label117;
    private Label label119;
    private Label label120;
    private Label label121;
    private Label label122;
    private Label label123;
    private Label label124;
    private Label label125;
    private Label lb_PITCH_PWM_MAX;
    private Label lb_PITCH_PWM_MIN;
    private TrackBar tb_PITCH_PWM_MIN;
    private Label lb_PITCH_FORCE_MAX;
    private TrackBar tb_PITCH_FORCE_MAX;
    private Label label129;
    private Label label130;
    private Label label131;
    private Label label132;
    private Label label133;
    private Label lb_PITCH_DAMPER_MAX_VELOCITY;
    private TrackBar tb_PITCH_DAMPER_MAX_VELOCITY;
    private Label lb_PITCH_INERTIA_MAX_ACCELERATION;
    private Label label136;
    private Label label137;
    private Label label138;
    private Label label139;
    private Label label140;
    private TrackBar tb_PITCH_INERTIA_MAX_ACCELERATION;
    private Label label141;
    private Label label142;
    private Label label143;
    private Label label144;
    private Label label145;
    private Label lb_PITCH_FRICTION_MAX_POSITION_CHANGE;
    private TrackBar tb_PITCH_FRICTION_MAX_POSITION_CHANGE;
    private Label lb_PITCH_FRICTION_GAIN;
    private Label label148;
    private Label label149;
    private Label label150;
    private Label label151;
    private Label label152;
    private TrackBar tb_PITCH_FRICTION_GAIN;
    private Label lb_PITCH_INERTIA_GAIN;
    private Label label160;
    private Label label161;
    private Label label162;
    private Label label163;
    private Label label164;
    private TrackBar tb_PITCH_INERTIA_GAIN;
    private Label label165;
    private Label label166;
    private Label label167;
    private Label label168;
    private Label label169;
    private Label lb_PITCH_DAMPER_GAIN;
    private TrackBar tb_PITCH_DAMPER_GAIN;
    private Label lb_PITCH_SPRING_GAIN;
    private Label label172;
    private Label label173;
    private Label label174;
    private Label label175;
    private Label label176;
    private TrackBar tb_PITCH_SPRING_GAIN;
    private Label label177;
    private Label label178;
    private Label label179;
    private Label label180;
    private Label label181;
    private Label lb_PITCH_SAWTOOTH_UP_GAIN;
    private TrackBar tb_PITCH_SAWTOOTH_UP_GAIN;
    private Label lb_PITCH_SAWTOOT_DOWN_GAIN;
    private Label label184;
    private Label label185;
    private Label label186;
    private Label label187;
    private Label label188;
    private TrackBar tb_PITCH_SAWTOOT_DOWN_GAIN;
    private Label label189;
    private Label label190;
    private Label label191;
    private Label label192;
    private Label label193;
    private Label lb_PITCH_TRIANGLE_GAIN;
    private TrackBar tb_PITCH_TRIANGLE_GAIN;
    private Label lb_PITCH_SIN_GAIN;
    private Label label196;
    private Label label197;
    private Label label198;
    private Label label199;
    private Label label200;
    private TrackBar tb_PITCH_SIN_GAIN;
    private Label label201;
    private Label label202;
    private Label label203;
    private Label label204;
    private Label label205;
    private Label lb_PITCH_SQUARE_GAIN;
    private TrackBar tb_PITCH_SQUARE_GAIN;
    private Label lb_PITCH_RAMP_GAIN;
    private Label label208;
    private Label label209;
    private Label label210;
    private Label label211;
    private Label label212;
    private TrackBar tb_PITCH_RAMP_GAIN;
    private Label label213;
    private Label label214;
    private Label label215;
    private Label label216;
    private Label label217;
    private Label lb_PITCH_CONSTANT_GAIN;
    private TrackBar tb_PITCH_CONSTANT_GAIN;
    private Label lb_PITCH_TOTAL_GAIN;
    private Label label220;
    private Label label221;
    private Label label222;
    private Label label223;
    private Label label224;
    private TrackBar tb_PITCH_TOTAL_GAIN;
    private TrackBar tb_PITCH_PWM_MAX;
    private PictureBox pbDebugYoke;
    private CheckBox cb_yoke_8;
    private CheckBox cb_yoke_7;
    private CheckBox cb_yoke_13;
    private CheckBox cb_yoke_15;
    private CheckBox cb_yoke_14;
    private CheckBox cb_yoke_12;
    private CheckBox cb_yoke_11;
    private CheckBox cb_yoke_10;
    private CheckBox cb_yoke_3;
    private CheckBox cb_yoke_2;
    private CheckBox cb_yoke_0;
    private CheckBox cb_yoke_1;
    private CheckBox cb_yoke_4;
    private CheckBox cb_yoke_9;
    private CheckBox cb_yoke_6;
    private CheckBox cb_yoke_5;
    private PictureBox tb_button_calibration_black;
    private PictureBox tb_button_calibration_green;
    private Label label225;
        private MenuStrip mainMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem websiteToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
    private Button btDebugStop;
    private Button btDebugStart;
        private Button btDisconnect;
    private Label label229;
    private PictureBox tb_sensor_left_green;
    private PictureBox tb_sensor_left_black;
    private Label label228;
    private PictureBox tb_sensor_right_green;
    private PictureBox tb_sensor_right_black;
    private Label label227;
    private PictureBox tb_sensor_up_green;
    private PictureBox tb_sensor_up_black;
    private Label label226;
    private PictureBox tb_sensor_down_green;
    private PictureBox tb_sensor_down_black;
    private Timer timerReplySettingsTimeout;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_SPEED_PITCH;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_COUNTER_ROLL;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_COUNTER_PITCH;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_FORCE_PITCH;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart_FORCE_ROLL;
    private Button btSettingsClearEeprom;
  }
}