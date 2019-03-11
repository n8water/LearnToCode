using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        //Variables
        bool isPangram = false;        
        string allLower;

        //Create abc in list
        List<char> abc = new List<char>();
        for (int i = 0; i < 26; i++)
        {
            abc.Add((char)(97 + i));
        }

        //Change input to lower case
        allLower = input.ToLower();

        //if input to short for pangram
        if (allLower.Length < 26)
            isPangram = false;
        else
        {
            foreach (char c in allLower)
            {
                if (abc.Contains(c))
                    abc.Remove(c);
            }

            if (abc.Count == 0)
                isPangram = true;
        }
        return isPangram;
    }

}
