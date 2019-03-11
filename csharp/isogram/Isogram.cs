using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        //Variables and Prerequisites
        bool isIsogram = false;
        List<char> abcList = GenerateAbcList();
        string input;
        string inputClean = "";

        //Clean input
        input = word.ToLower();
        foreach (char c in input)
        {
            if (char.IsLetter(c))
                inputClean += c;
        }

        //Check Input
        foreach (char c in inputClean)
        {                
            if (abcList.Contains(c))
                abcList.Remove(c);
            else
                return isIsogram;
        }

        isIsogram = true;

        return isIsogram;
    }

    private static List<char> GenerateAbcList()
    {
        List<char> abc = new List<char>(26);

        for (int i = 0; i < 26; i++)
        {
            abc.Add((char)(97+i));
        }

        return abc;
    }

}
