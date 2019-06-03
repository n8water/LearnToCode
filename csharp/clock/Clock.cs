using System;
using System.Text;

public class Clock
{
    private int _hours;
    private int _minutes;
    
    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public int Hours
    {
        get
        {
            return _hours;
        }
        set
        {
            while(value < 0)
            {
                value += 24;
            }

            while(value > 23)
            {
                value -= 24;
            }

            _hours = value;            
        }
    }

    public int Minutes
    {
        get
        {
            return _minutes;
        }
        set
        {
            int counter = 0;
            while(value > 59)
            {
                value -= 60;
                counter++;
            }

            _minutes = value;
            //Add(60 * counter);


                
        }
    }

    public Clock Add(int minutesToAdd)
    {
        var changedTime = new DateTime(2019, 06, 03, _hours, _minutes, 0);
        changedTime = changedTime.AddMinutes(minutesToAdd);
        //changedTime.ToShortTimeString();
        Hours = changedTime.Hour;
        Minutes = changedTime.Minute;

        return new Clock(_hours, _minutes);

    }

    public Clock Subtract(int minutesToSubtract)
    {
        var changedTime = new DateTime(2019, 06, 03, _hours, _minutes, 0);
        changedTime = changedTime.AddMinutes(minutesToSubtract);
        Hours = changedTime.Hour;
        Minutes = changedTime.Minute;

        return this;
    }

    public override string ToString()
    {
        return string.Format("{0:00}:{1:00}", _hours, _minutes);
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);    
    }
}