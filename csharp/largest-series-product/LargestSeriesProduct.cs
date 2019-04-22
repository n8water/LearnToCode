using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        long result = 0;
        List<long> segments = new List<long>();
        long temp = 1;

        if(string.IsNullOrEmpty(digits) || (digits.Length < span) || span <= 0)
            throw new ArgumentException();
        
        for (int i = 0; i <= digits.Length-span; i++)
        {
            if(!digits.Substring(i,span).Contains('0'))
            {
                segments.Add(Convert.ToInt64(digits.Substring(i,span)));
            }
        }

        


        return result;
    }
}