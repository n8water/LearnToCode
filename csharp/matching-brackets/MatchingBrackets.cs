using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    static string openingBrackets = "([{";
    static string closingBrackets = ")]}";
    static Stack<char> inputBrackets = new Stack<char>();
    static bool isPaired;

    public static bool IsPaired(string input)
    {
        inputBrackets.Clear();
        isPaired = false;

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
                    isPaired = checkIfBracketsPair(c);
                }
            }
        }        

        if(inputBrackets.Count != 0)
            isPaired = false;
        
        return isPaired;
    }

    private static bool checkIfBracketsPair(char c)
    {
        if(inputBrackets.Count > 0 && (openingBrackets.IndexOf(inputBrackets.Pop()) == closingBrackets.IndexOf(c)))
        {
            return true;
        }
        else
            return false;
    }
}
