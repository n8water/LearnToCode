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
    private readonly int _year;
    private readonly int _month;
    private int _meetingDay;
    private DateTime _dayOfMeeting;

    //Constructor
    public Meetup(int month, int year)
    {
        _month = month;
        _year = year;

    }

    //Methods
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        int daysInMonth = DateTime.DaysInMonth(_year, _month);
        int[] daysOfMonth = new int[daysInMonth];

        for (int i = 0; i < daysInMonth; i++)
        {
            daysOfMonth[i] = i+1;
        }

        List<int> possibleMeetingDates = (List<int>) daysOfMonth.Where((d, i) => (d <= daysInMonth) && (new DateTime(_year, _month, i+1).DayOfWeek == dayOfWeek)).Select(x => x);

        switch (schedule)
        {
            case Schedule.Teenth:
                _meetingDay = Convert.ToInt32(possibleMeetingDates.Where(d => d < 20 && d >12));
                break;
            case Schedule.First:
                _meetingDay = possibleMeetingDates.First();
                break;
            case Schedule.Second:
                _meetingDay = possibleMeetingDates[1];
                break;
            case Schedule.Third:
                _meetingDay = possibleMeetingDates[2];
                break;
            case Schedule.Fourth:
                _meetingDay = possibleMeetingDates[3];
                break;
            case Schedule.Last:
                _meetingDay = possibleMeetingDates.Last();
                break;
            default:
                throw new ArgumentException();
                
        }

        return _dayOfMeeting= new DateTime(_year, _month, _meetingDay);
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
 
