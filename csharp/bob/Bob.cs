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

        //var output = input.Where(c => !char.IsNumber(c)?c:);

        //string shouting = statement.ToUpper();
        statement = statement.Trim();



        if(statement.EndsWith("?") && IsShouting(statement))
        {
            answer= "Calm down, I know what I'm doing!";
        }
        else if(statement.EndsWith("?"))
        {
            answer = "Sure.";
        }
        else if (IsShouting(statement) && statement.EndsWith("!") || IsNumeric(statement) && statement.EndsWith("!"))
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



        bool IsShouting(string stringToCheck)
        {
            bool isShouting = false;
            var cleanString = stringToCheck.Where(c => char.IsLetter(c));
            
            isShouting = cleanString.All<char>(c => char.IsUpper(c));

            return isShouting;
        }

        bool IsNumeric(string stringToCheck)
        {
            bool isNumeric = stringToCheck.All<char>(c => char.IsNumber(c) | char.IsPunctuation(c) | char.IsSeparator(c));
            return isNumeric;
        }
    }

    public static class StringExtensionMethods
    {


    }
}