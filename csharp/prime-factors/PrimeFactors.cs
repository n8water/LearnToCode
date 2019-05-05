using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static int[] Factors(long number)
    {
        List<int> result = new List<int>();
        int factor = 2;

        while(number != 1)
        {
            if(number % factor == 0)
            {
                result.Add(factor);
                number /=  factor;
            }
            else
                factor++;
        }

        return result.ToArray();
    }
}