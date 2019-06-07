using System;
using System.Text;

public class Clock : IEquatable<Clock>
{
    private int hours;
    private int minutes;
    
    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

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

            minutes = value;
            Hours += counter;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        var changedTime = new DateTime(2019, 06, 03, hours, minutes, 0);
        changedTime = changedTime.AddMinutes(minutesToAdd);
        Hours = changedTime.Hour;
        Minutes = changedTime.Minute;

        return new Clock(hours, minutes);

    }

    public Clock Subtract(int minutesToSubtract)
    {
        var changedTime = new DateTime(2019, 06, 03, hours, minutes, 0);
        changedTime = changedTime.AddMinutes(minutesToSubtract * -1);
        Hours = changedTime.Hour;
        Minutes = changedTime.Minute;

        return this;
    }

    public override string ToString()
    {
        return string.Format("{0:00}:{1:00}", hours, minutes);
    }

    public bool Equals(Clock other)
    {
        throw new NotImplementedException();
    }
}