using System;
using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> recite = new List<string>();
        if (subjects.Length <= 0)
            return recite.ToArray();

        for (int i = 0; i+1 < subjects.Length; i++)
        {
            recite.Add($"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }
        recite.Add($"And all for the want of a {subjects[0]}.");

        return recite.ToArray();
    }
}
