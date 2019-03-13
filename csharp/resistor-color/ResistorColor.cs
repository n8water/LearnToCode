using System;
using System.Drawing;
using System.Linq;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        int colorCode = Array.IndexOf(Colors(), color);
        return colorCode;
    }

    public static string[] Colors()
    {
        string[] colors = {"black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"};
        return colors;
    }
}