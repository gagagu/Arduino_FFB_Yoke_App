using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arduino_FFB_Yoke_App
{
  /// <summary>
  /// Command value constants
  /// </summary>
  public static class Constants
  {
    public const int SERIAL_CMD_DEBUG_START = 1;
    public const int SERIAL_CMD_DEBUG_STOP = 2;
    public const int SERIAL_CMD_DEBUG_STATUS = 3;
    public const int SERIAL_CMD_DEBUG_VALUES = 4;

    public const int SERIAL_CMD_ALL_PARAMS = 10;
    public const int SERIAL_CMD_ALL_VALUES = 20;


    public const int SERIAL_CDM_WRITE_ROLL_FORCE_MAX = 101;
    public const int SERIAL_CDM_WRITE_ROLL_PWM_MIN = 102;
    public const int SERIAL_CDM_WRITE_ROLL_PWM_MAX = 103;

    public const int SERIAL_CDM_WRITE_ROLL_FRICTION_MAX_POSITION_CHANGE = 104;
    public const int SERIAL_CDM_WRITE_ROLL_INERTIA_MAX_ACCELERATION = 105;
    public const int SERIAL_CDM_WRITE_ROLL_DAMPER_MAX_VELOCITY = 106;

    public const int SERIAL_CDM_WRITE_ROLL_TOTAL_GAIN = 107;
    public const int SERIAL_CDM_WRITE_ROLL_CONSTANT_GAIN = 108;
    public const int SERIAL_CDM_WRITE_ROLL_RAMP_GAIN = 109;
    public const int SERIAL_CDM_WRITE_ROLL_SQUARE_GAIN = 110;
    public const int SERIAL_CDM_WRITE_ROLL_SINE_GAIN = 111;
    public const int SERIAL_CDM_WRITE_ROLL_TRIANGLE_GAIN = 112;
    public const int SERIAL_CDM_WRITE_ROLL_SAWTOOTH_DOWN_GAIN = 113;
    public const int SERIAL_CDM_WRITE_ROLL_SAWTOOTH_UP_GAIN = 114;
    public const int SERIAL_CDM_WRITE_ROLL_SPRING_GAIN = 115;
    public const int SERIAL_CDM_WRITE_ROLL_DAMPER_GAIN = 116;
    public const int SERIAL_CDM_WRITE_ROLL_INERTIA_GAIN = 117;
    public const int SERIAL_CDM_WRITE_ROLL_FRICTION_GAIN = 118;

    public const int SERIAL_CDM_WRITE_PITCH_FORCE_MAX = 119;
    public const int SERIAL_CDM_WRITE_PITCH_PWM_MIN = 120;
    public const int SERIAL_CDM_WRITE_PITCH_PWM_MAX = 121;

    public const int SERIAL_CDM_WRITE_PITCH_FRICTION_MAX_POSITION_CHANGE = 122;
    public const int SERIAL_CDM_WRITE_PITCH_INERTIA_MAX_ACCELERATION = 123;
    public const int SERIAL_CDM_WRITE_PITCH_DAMPER_MAX_VELOCITY = 124;

    public const int SERIAL_CDM_WRITE_PITCH_TOTAL_GAIN = 125;
    public const int SERIAL_CDM_WRITE_PITCH_CONSTANT_GAIN = 126;
    public const int SERIAL_CDM_WRITE_PITCH_RAMP_GAIN = 127;
    public const int SERIAL_CDM_WRITE_PITCH_SQUARE_GAIN = 128;
    public const int SERIAL_CDM_WRITE_PITCH_SINE_GAIN = 129;
    public const int SERIAL_CDM_WRITE_PITCH_TRIANGLE_GAIN = 130;
    public const int SERIAL_CDM_WRITE_PITCH_SAWTOOTH_DOWN_GAIN = 131;
    public const int SERIAL_CDM_WRITE_PITCH_SAWTOOTH_UP_GAIN = 132;
    public const int SERIAL_CDM_WRITE_PITCH_SPRING_GAIN = 133;
    public const int SERIAL_CDM_WRITE_PITCH_DAMPER_GAIN = 134;
    public const int SERIAL_CDM_WRITE_PITCH_INERTIA_GAIN = 135;
    public const int SERIAL_CDM_WRITE_PITCH_FRICTION_GAIN = 136;

    public const int SERIAL_CMD_WRITE_DATA_EEPROM = 250;
    public const int SERIAL_CMD_WRITE_EEPROM_CLEAR = 251;
  }
}
