using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    private static readonly string openingBrackets = "([{";
    private static readonly string closingBrackets = ")]}";
    static bool isPaired = false;

    public static bool IsPaired(string input)
    {
        var inputBrackets = new Stack<char>();

        if(input == string.Empty)
            isPaired = true;
        else
        {
            foreach (char c in input)
            {
                if (openingBrackets.Contains(c))
                {
                    inputBrackets.Push(c);
                }
                else if (closingBrackets.Contains(c))
                {
                    isPaired = checkIfBracketsPair(c, inputBrackets);
                }
            }
        }        

        if(inputBrackets.Count != 0)
            isPaired = false;
        
        return isPaired;
    }

    private static bool checkIfBracketsPair(char c, Stack<char>brackets)
    {
        return brackets.Count > 0 && (openingBrackets.IndexOf(brackets.Pop()) == closingBrackets.IndexOf(c));
    }
}
