using System;
using System.Text;

public class Clock : IEquatable<Clock>
{
    #region private fields and properties
    private int hours;
    private int minutes;

    public int Hours
    {
        get
        {
            return hours;
        }
        set
        {
            while(value < 0)
            {
                value += 24;
            }
            while(value >= 24)
            {
                value -= 24;
            }
            hours = value;            
        }
    }

    public int Minutes
    {
        get
        {
            return minutes;
        }
        set
        {
            int counter = 0;
            while(value < 0)
            {
                value += 60;
                counter--;
            }
            while(value > 59)
            {
                value -= 60;
                counter++;
            }
            Hours += counter;
            minutes = value;
        }
    }
    #endregion

    #region ctor
    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }
    #endregion

    #region Methods

    public Clock Add(int minutesToAdd)
    {
        var changedTime = new DateTime(2019, 06, 03, hours, minutes, 0);
        changedTime = changedTime.AddMinutes(minutesToAdd);
        return new Clock(changedTime.Hour, changedTime.Minute);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        var changedTime = new DateTime(2019, 06, 03, hours, minutes, 0);
        changedTime = changedTime.AddMinutes(minutesToSubtract * -1);
        return new Clock(changedTime.Hour, changedTime.Minute);
    }

    public bool Equals(Clock other)
    {
        if((this.Hours == other.Hours) && (this.Minutes == other.Minutes))
            return true;
        else
            return false;
    }

    public override string ToString()
    {
        return string.Format("{0:00}:{1:00}", hours, minutes);
    }
    #endregion
}