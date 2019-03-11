using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string result = string.Empty;
        string temp = input;
        int length = input.Length;

        while (length > 0)
        {
            result += temp.Last();
            temp = temp.Remove(length-1);
            length--;
        }

        return result;
    }
}