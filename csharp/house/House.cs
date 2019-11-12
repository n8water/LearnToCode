using System;
using System.Collections.Generic;

public static class House
{
    //private static readonly List<(string who, string what)> lines = new List<(string, string)>();
    //private static readonly List<string> verses = new List<string>();

    private static readonly List<string> who = new List<string>()
    {   
        "malt",
        "rat",
        "cat",
        "dog",
        "cow with the crumpled horn",
        "maiden all forlorn",
        "man all tattered and torn",
        "priest all shaven and shorn",
        "rooster that crowed in the morn",
        "farmer sowing his corn",
        "horse and the hound and the horn"
    };

    private static readonly List<string> what = new List<string>()
    {
        "lay",
        "ate",
        "killed",
        "worried",
        "tossed",
        "milked",
        "kissed",
        "married",
        "woke",
        "kept",
        "belonged to"
    };

    public static string Recite(int verseNumber)
    {
        return Verse(verseNumber);        
    }

    public static string Recite(int startVerse, int endVerse)
    {
        string result = string.Empty;

        for(int i = startVerse; i <= endVerse; i++)
        {
            if (result == string.Empty)
                result += Verse(i);
            else
                result += "\n" + Verse(i);
        }

        return result;
    }

    private static string Verse(int verseNumber)
    {
        string result = string.Empty;
        string verseStart = "This is the ";
        string endVerseOne = "house that Jack built.";
        string verseEnd = " in the house that Jack built.";

        if (verseNumber == 1)
        {
            result += verseStart + endVerseOne;
        }
        else
        {
            result += verseStart;
            for(int i = verseNumber - 2; i >= 0; i--)
            {
                result += who[i] + " that " + what[i];
                if (i == 0)
                    result += verseEnd;
                else
                    result += " the ";
            }
        }

        return result;
    }
}