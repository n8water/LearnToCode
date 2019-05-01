using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        long largestProduct = 0;
        long temp = 1;
        long tempDigits;
        List<string> slices = new List<string>();

        if (digits.Length < 0 || span < 0 || span > digits.Length)
            throw new ArgumentException();

        if(digits.Length == 0 && span == 0 || span == 0)
            return 1;

        if(!double.TryParse(digits, out double result))
            throw new ArgumentException();

        for (int i = 0; i + span <= digits.Length; i++)
        {
            slices.Add(digits.Substring(i, span));
        }

        foreach  (string slice in slices)
        {            
            if (slice.Contains('0'))
                continue;

            tempDigits = Convert.ToInt64(slice);
                        
            while (tempDigits >= 10)
            {
                temp *= tempDigits % 10;
                tempDigits = tempDigits / 10;
            }
            temp *= tempDigits;

            if (temp > largestProduct)
            {
                largestProduct = temp;
                temp = 1;
            }
            else
            {
                temp = 1;
            }
        }

        return largestProduct;
    }
}