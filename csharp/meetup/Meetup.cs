using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection;
using Xunit.Sdk;
using System.Linq;
using System.Collections.Generic;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}


public class Meetup
{
    private int _year { get; }
    private int _month { get; }

    private int _day;
    private DateTime _dayOfMeeting;

    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;

    }

    #region My Solution
    //public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    //{
    //    int numberOfDays = DateTime.DaysInMonth(_year, _month);

    //    List<int> possibleDays = new List<int>();

    //    for (int i = 1; i <= numberOfDays; i++)
    //    {
    //        if (new DateTime(_year, _month, i).DayOfWeek == dayOfWeek)
    //            possibleDays.Add(i);
    //    }

    //    var teenth = possibleDays.Where(x => (x > 12) && (x < 20)).Select(x => x);

    //    switch (schedule)
    //    {
    //        case Schedule.Teenth:
    //            _day = teenth.First();
    //            break;
    //        case Schedule.First:
    //            _day = possibleDays.First();
    //            break;
    //        case Schedule.Second:
    //            _day = possibleDays[1];
    //            break;
    //        case Schedule.Third:
    //            _day = possibleDays[2];
    //            break;
    //        case Schedule.Fourth:
    //            _day = possibleDays[3];
    //            break;
    //        case Schedule.Last:
    //            _day = possibleDays.Last();
    //            break;
    //        default:
    //            throw new ArgumentException();
    //    }

    //    _dayOfMeeting = new DateTime(_year, _month, _day);

    //    return _dayOfMeeting;

    //} 
    #endregion

    //Lösung aus Community mit LinQ
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var days = Enumerable
            .Range(1, DateTime.DaysInMonth(_year, _month))
            .Select(day => new DateTime(_year, _month, day))
            .Where(date => date.DayOfWeek == dayOfWeek)
            .ToList();

        switch (schedule)
        {
            case Schedule.First: return days[0];
            case Schedule.Second: return days[1];
            case Schedule.Third: return days[2];
            case Schedule.Fourth: return days[3];
            case Schedule.Last: return days.Last();
            case Schedule.Teenth: return days.First(date => date.Day > 12);
        }
        throw new ArgumentOutOfRangeException();
    }
}



/*
Calculate the date of meetups.

Typically meetups happen on the same day of the week.  In this exercise, you
will take a description of a meetup date, and return the actual meetup date.
 
Examples of general descriptions are:

- The first Monday of January 2017
- The third Tuesday of January 2017
- The wednesteenth of January 2017
- The last Thursday of January 2017

The descriptors you are expected to parse are:
first, second, third, fourth, fifth, last, monteenth, tuesteenth, wednesteenth,
thursteenth, friteenth, saturteenth, sunteenth

Given examples of a meetup dates, each containing a month, day, year, and
descriptor calculate the date of the actual meetup.  For example, if given
"The first Monday of January 2017", the correct meetup date is 2017/1/2.
 */
 
