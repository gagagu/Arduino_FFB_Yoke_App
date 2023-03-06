using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_FFB_Yoke_App
{
  /// <summary>
  /// Helper file to shrink mainform.cs 
  /// </summary>
  public partial class Mainform : Form
  {
    /// <summary>
    /// assign Trackbars to tooltip.
    /// </summary>
    public void SetTrackBarToolTips()
    {
      mainToolTip.SetToolTip(tb_ROLL_FORCE_MAX, tb_ROLL_FORCE_MAX.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_PWM_MAX, tb_ROLL_PWM_MAX.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_PWM_MIN, tb_ROLL_PWM_MIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_DAMPER_MAX_VELOCITY, tb_ROLL_DAMPER_MAX_VELOCITY.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_INERTIA_MAX_ACCELERATION, tb_ROLL_INERTIA_MAX_ACCELERATION.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_FRICTION_MAX_POSITION_CHANGE, tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_FRICTION_GAIN, tb_ROLL_FRICTION_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_INERTIA_GAIN, tb_ROLL_INERTIA_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_DAMPER_GAIN, tb_ROLL_DAMPER_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_SPRING_GAIN, tb_ROLL_SPRING_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_SAWTOOTH_UP_GAIN, tb_ROLL_SAWTOOTH_UP_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_SAWTOOT_DOWN_GAIN, tb_ROLL_SAWTOOT_DOWN_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_TRIANGLE_GAIN, tb_ROLL_TRIANGLE_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_SIN_GAIN, tb_ROLL_SIN_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_SQUARE_GAIN, tb_ROLL_SQUARE_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_RAMP_GAIN, tb_ROLL_RAMP_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_CONSTANT_GAIN, tb_ROLL_CONSTANT_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_ROLL_TOTAL_GAIN, tb_ROLL_TOTAL_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_PWM_MIN, tb_PITCH_PWM_MIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_FORCE_MAX, tb_PITCH_FORCE_MAX.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_DAMPER_MAX_VELOCITY, tb_PITCH_DAMPER_MAX_VELOCITY.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_INERTIA_MAX_ACCELERATION, tb_PITCH_INERTIA_MAX_ACCELERATION.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_FRICTION_MAX_POSITION_CHANGE, tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_FRICTION_GAIN, tb_PITCH_FRICTION_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_INERTIA_GAIN, tb_PITCH_INERTIA_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_DAMPER_GAIN, tb_PITCH_DAMPER_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_SPRING_GAIN, tb_PITCH_SPRING_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_SAWTOOTH_UP_GAIN, tb_PITCH_SAWTOOTH_UP_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_SAWTOOT_DOWN_GAIN, tb_PITCH_SAWTOOT_DOWN_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_TRIANGLE_GAIN, tb_PITCH_TRIANGLE_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_SIN_GAIN, tb_PITCH_SIN_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_SQUARE_GAIN, tb_PITCH_SQUARE_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_RAMP_GAIN, tb_PITCH_RAMP_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_CONSTANT_GAIN, tb_PITCH_CONSTANT_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_TOTAL_GAIN, tb_PITCH_TOTAL_GAIN.Value.ToString());
      mainToolTip.SetToolTip(tb_PITCH_PWM_MAX, tb_PITCH_PWM_MAX.Value.ToString());

    }

    /// <summary>
    /// Update Tooltip by scrolling Trackbars
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void tb_ROLL_FORCE_MAX_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_FORCE_MAX, tb_ROLL_FORCE_MAX.Value.ToString());
    }
    private void tb_ROLL_PWM_MAX_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_PWM_MAX, tb_ROLL_PWM_MAX.Value.ToString());
    }

    private void tb_ROLL_PWM_MIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_PWM_MIN, tb_ROLL_PWM_MIN.Value.ToString());

    }

    private void tb_ROLL_TOTAL_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_TOTAL_GAIN, tb_ROLL_TOTAL_GAIN.Value.ToString());

    }

    private void tb_ROLL_CONSTANT_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_CONSTANT_GAIN, tb_ROLL_CONSTANT_GAIN.Value.ToString());

    }

    private void tb_ROLL_RAMP_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_RAMP_GAIN, tb_ROLL_RAMP_GAIN.Value.ToString());

    }

    private void tb_ROLL_SQUARE_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_SQUARE_GAIN, tb_ROLL_SQUARE_GAIN.Value.ToString());

    }

    private void tb_ROLL_SIN_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_SIN_GAIN, tb_ROLL_SIN_GAIN.Value.ToString());

    }

    private void tb_ROLL_TRIANGLE_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_TRIANGLE_GAIN, tb_ROLL_TRIANGLE_GAIN.Value.ToString());

    }

    private void tb_ROLL_SAWTOOT_DOWN_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_SAWTOOT_DOWN_GAIN, tb_ROLL_SAWTOOT_DOWN_GAIN.Value.ToString());

    }

    private void tb_ROLL_SAWTOOTH_UP_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_SAWTOOTH_UP_GAIN, tb_ROLL_SAWTOOTH_UP_GAIN.Value.ToString());

    }

    private void tb_ROLL_SPRING_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_SPRING_GAIN, tb_ROLL_SPRING_GAIN.Value.ToString());

    }

    private void tb_ROLL_DAMPER_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_DAMPER_GAIN, tb_ROLL_DAMPER_GAIN.Value.ToString());

    }

    private void tb_ROLL_INERTIA_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_INERTIA_GAIN, tb_ROLL_INERTIA_GAIN.Value.ToString());

    }


    private void tb_ROLL_FRICTION_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_FRICTION_GAIN, tb_ROLL_FRICTION_GAIN.Value.ToString());

    }

    private void tb_ROLL_FRICTION_MAX_POSITION_CHANGE_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_FRICTION_MAX_POSITION_CHANGE, tb_ROLL_FRICTION_MAX_POSITION_CHANGE.Value.ToString());

    }

    private void tb_ROLL_INERTIA_MAX_ACCELERATION_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_INERTIA_MAX_ACCELERATION, tb_ROLL_INERTIA_MAX_ACCELERATION.Value.ToString());

    }

    private void tb_ROLL_DAMPER_MAX_VELOCITY_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_ROLL_DAMPER_MAX_VELOCITY, tb_ROLL_DAMPER_MAX_VELOCITY.Value.ToString());

    }


    private void tb_PITCH_FORCE_MAX_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_FORCE_MAX, tb_PITCH_FORCE_MAX.Value.ToString());
    }

    private void tb_PITCH_PWM_MIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_PWM_MIN, tb_PITCH_PWM_MIN.Value.ToString());

    }

    private void tb_PITCH_PWM_MAX_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_PWM_MAX, tb_PITCH_PWM_MAX.Value.ToString());

    }

    private void tb_PITCH_TOTAL_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_TOTAL_GAIN, tb_PITCH_TOTAL_GAIN.Value.ToString());

    }

    private void tb_PITCH_CONSTANT_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_CONSTANT_GAIN, tb_PITCH_CONSTANT_GAIN.Value.ToString());

    }

    private void tb_PITCH_SQUARE_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_SQUARE_GAIN, tb_PITCH_SQUARE_GAIN.Value.ToString());

    }

    private void tb_PITCH_RAMP_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_RAMP_GAIN, tb_PITCH_RAMP_GAIN.Value.ToString());

    }

    private void tb_PITCH_SIN_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_SIN_GAIN, tb_PITCH_SIN_GAIN.Value.ToString());

    }

    private void tb_PITCH_TRIANGLE_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_TRIANGLE_GAIN, tb_PITCH_TRIANGLE_GAIN.Value.ToString());

    }

    private void tb_PITCH_SAWTOOT_DOWN_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_SAWTOOT_DOWN_GAIN, tb_PITCH_SAWTOOT_DOWN_GAIN.Value.ToString());

    }

    private void tb_PITCH_SAWTOOT_UP_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_SAWTOOTH_UP_GAIN, tb_PITCH_SAWTOOTH_UP_GAIN.Value.ToString());

    }

    private void tb_PITCH_SPRING_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_SPRING_GAIN, tb_PITCH_SPRING_GAIN.Value.ToString());

    }

    private void tb_PITCH_DAMPER_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_DAMPER_GAIN, tb_PITCH_DAMPER_GAIN.Value.ToString());

    }

    private void tb_PITCH_INERTIA_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_INERTIA_GAIN, tb_PITCH_INERTIA_GAIN.Value.ToString());

    }



    private void tb_PITCH_FRICTION_GAIN_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_FRICTION_GAIN, tb_PITCH_FRICTION_GAIN.Value.ToString());

    }

    private void tb_PITCH_FRICTION_MAX_POSITION_CHANGE_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_FRICTION_MAX_POSITION_CHANGE, tb_PITCH_FRICTION_MAX_POSITION_CHANGE.Value.ToString());

    }

    private void tb_PITCH_INERTIA_MAX_ACCELERATION_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_INERTIA_MAX_ACCELERATION, tb_PITCH_INERTIA_MAX_ACCELERATION.Value.ToString());

    }

    private void tb_PITCH_DAMPER_MAX_VELOCITY_Scroll(object sender, EventArgs e)
    {
      mainToolTip.SetToolTip(tb_PITCH_DAMPER_MAX_VELOCITY, tb_PITCH_DAMPER_MAX_VELOCITY.Value.ToString());

    }
  }
}
