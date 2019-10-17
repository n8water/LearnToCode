using System;
using System.Collections.Generic;

public static class House
{
    private static readonly Dictionary<string, string> versValues = new Dictionary<string, string>
    {
        { "malt", "lay"},
        { "rat", "ate" },
        { "cat", "killed" },
        { "dog", "worried" },
        { "cow with the crumpled horn", "tossed" },
        { "maiden all forlorn", "milked" },
        { "man all tattered and torn", "kissed" },
        { "priest all shaven and shorn", "married" },
        { "rooster that crowed in the morn", "woke" },
        { "farmer sowing his corn", "kept" },
        { "horse and the hound and the horn", "belonged" },
    };
    public static string Recite(int verseNumber)
    {
        return Verse(verseNumber);
        throw new NotImplementedException("You need to implement this function.");
    }

    public static string Recite(int startVerse, int endVerse)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    private static string Verse(int verseNumber)
    {
        string start = "This is the ";

        string end1 = "house that Jack built.";
        string end = "in the house that Jack built.";

        if (verseNumber == 1)
            return "This is the house that Jack built.";
        else
            throw new NotImplementedException("to be done");
    }
}