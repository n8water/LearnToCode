using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        bool isLeapYear = false;

        if ((year % 4 == 0) && (year % 100 != 0))
            isLeapYear = true;
        else if((year % 4 == 0) && (year % 100 == 0) && (year % 400 == 0))
            isLeapYear = true;

        return isLeapYear;
    }
}