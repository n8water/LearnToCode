using System;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string input = string.Empty;
        string result = string.Empty;
        string[] words = new string[]{ };
        
        foreach (char c in phrase)
        {
            if ((c == '-') | (c == '_'))
            {
                input += " ";
            }
            else
            {
                input += c;
            }
        }

        words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {

            result += words[i][0];
        }

        result = result.ToUpper();

        return result;
    }
}