using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        private static readonly Dictionary<char, char> brackets = new Dictionary<char, char>()
        {
            '(' , ')';
        
        };
        

        if(input.Length == 0)
            return true;
        else
            return false;
    }
}
