using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        string input = statement.Trim();
        int isUpper = string.Compare(input, input.ToUpper());
        bool stringContainsNoLetters = CheckForLetters(input);
        
        if(input == string.Empty)
        {
            return "Fine. Be that way!";
        }
        else if((input.EndsWith("?") && isUpper != 0) || input.EndsWith("?") && stringContainsNoLetters)
        {
            return "Sure.";
        }
        else if (isUpper == 0 && input.EndsWith("?"))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (isUpper == 0 && !stringContainsNoLetters)
        {
            return "Whoa, chill out!";
        }
        else
        {
            return "Whatever.";
        }
    }

    private static bool CheckForLetters(string stringToCheck)
    {
        bool temp = false;
        
        stringToCheck = stringToCheck.Replace(" ", string.Empty);

        foreach (char c in stringToCheck)
        {
            if (char.IsNumber(c) || char.IsPunctuation(c))
            {
                temp = true;
            }
            else
            {
                temp = false;
                break;
            }
        }
        return temp;
    }
}