using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        long largestProduct = 0;

        if (digits.Length <= 0 || span <= 0)
            throw new ArgumentException();

        List<char> input = digits.ToList();

        for (int i = 0; i+span <= input.Count; i++)
        {
            
        }

    }
}