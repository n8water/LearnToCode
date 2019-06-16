using System;
using System.Collections.Generic;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string answer = string.Empty;

        var input = statement.ToCharArray();
        List<char> temp = new List<char>();

        foreach (char c in input)
        {
            if(char.IsLetter(c) | char.IsPunctuation(c))
            {
                temp.Add(c);
            }
        }

        var output = input.Where(c => !char.IsNumber(c)?c:(char)32);

        string shouting = statement.ToUpper();
        statement = statement.Trim();

        if(statement.EndsWith("?") && statement == shouting)
        {
            answer= "Calm down, I know what I'm doing!";
        }
        else if(statement.EndsWith("?"))
        {
            answer = "Sure.";
        }
        else if (statement.EndsWith("!") || statement == shouting)
        {
            answer = "Whoa, chill out!";
        }
        else if(statement == string.Empty)
        {
            answer = "Fine. Be that way!";
        }
        else
        {
            answer = "Whatever.";
        }

        return answer;
    }

    public static class StringExtensionMethods
    {
        static void IsUpperCase(string input)
        {
            
        }


    }
}