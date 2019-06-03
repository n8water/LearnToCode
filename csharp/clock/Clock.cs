using System;
using System.Text;

public class Clock
{
    private int _hours;
    private int _minutes;
    
    public Clock(int hours, int minutes)
    {
        _hours = hours;
        _minutes = minutes;
    }

    public int Hours
    {
        get
        {
            return _hours;
        }
    }

    public int Minutes
    {
        get
        {
            return _minutes;
        }
    }

    public Clock Add(int minutesToAdd)
    {
        

        int newMinutes = _minutes + minutesToAdd;
        if(newMinutes<0)
        {

        }
        
        throw new NotImplementedException("You need to implement this function.");

    }

    public Clock Subtract(int minutesToSubtract)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public override string ToString()
    {
        return string.Format("{0:00}:{1:00}", _hours, _minutes);
    }
}