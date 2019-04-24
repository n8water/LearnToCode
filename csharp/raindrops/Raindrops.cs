using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string result = string.Empty;
        Dictionary<int, string> factors = new Dictionary<int, string>
            {
                {3,"Pling"},
                {5,"Plang"},
                {7,"Plong"},
            };

        foreach (var key in factors.Keys)
        {
            if (number % key == 0)
                result += factors[key];
        }

        if (result == string.Empty)
            result = number.ToString();
        
        return result;
    }
}