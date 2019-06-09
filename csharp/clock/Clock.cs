using System;
using System.Text;

public class Clock : IEquatable<Clock>
{
    #region private fields and properties
    private int hours;
    private int minutes;

    //public int Hours { get; private set; }
    public int Hours
    {
        get => hours;
    }
    public int Minutes
    {
        get => minutes;
    }
    #endregion

    #region ctor
    public Clock(int hours, int minutes)
    {
        SetHour(hours);
        SetMinute(minutes);
    }
    #endregion

    #region Methods
    private void SetHour(int hour)
    {
        int temp = hour % 24;

        if(temp < 0)
            hours = temp + 24;            
        else
            hours = temp;
    }

    private void SetMinute(int minute)
    {
        int temp = minute % 60;
        int changeHour = minute / 60;

        if(temp < 0)
        {
            minutes = temp + 60;
            changeHour--;
        }
        else
            minutes = temp;

        if(changeHour != 0)
            SetHour(hours + changeHour);
    }

    public Clock Add(int minutesToAdd)
    {
        int newMinutes = minutes + minutesToAdd;
        return new Clock(this.hours, newMinutes);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        int newMinutes = minutes - minutesToSubtract;
        return new Clock(hours, newMinutes);
    }

    public bool Equals(Clock other)
    {
        return ((this.Hours == other.Hours) && (this.Minutes == other.Minutes));
    }

    public override string ToString()
    {
        return string.Format("{0:00}:{1:00}", hours, minutes);
    }
    #endregion
}