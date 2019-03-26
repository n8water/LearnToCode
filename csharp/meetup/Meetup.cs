using System;
using System.Diagnostics;
using System.Reflection;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.DataCollection;
using Xunit.Sdk;

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
    //Variables
    private enum Teenth
    {
        Monteenth,
        Tuesteenth,
        Wednesteenth,
        Thursteenth,
        Friteenth,
        Saturteenth,
        Sunteenth
    }

    private string _descriptor;
    private int _year;
    private int _month;
    private int _day;
    private DayOfWeek _dayOfWeek;
    private DateTime _dayOfMeeting;

    //Constructor
    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;
        //_descriptor = _stackTrace.GetFrame(1).GetMethod().Name;
        _descriptor = new StackTrace().GetFrame(1).GetMethod().Name;
    }

    //Methods
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        throw new NotImplementedException("You need to implement this function.");
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
 
