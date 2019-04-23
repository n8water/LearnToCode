using System;
using System.Collections.Generic;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var item in old)
        {
            var key = item.Key;
            var values = item.Value;

            foreach (string value in values)
            {
                result.Add(value.ToLower(), key);
            }
        }                          
        return result;
    }
}