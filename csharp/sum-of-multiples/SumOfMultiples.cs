using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int sum = 0;

        List<int> numbersToSumUp = new List<int>();
        foreach (int number in multiples)
        {
            if (number != 0)
                for (int i = 1; i < max; i++)
                {
                    if (i % number == 0 && !numbersToSumUp.Contains(i))
                    {
                        numbersToSumUp.Add(i);
                        sum += i;
                    }
                }
        }        
        return sum;

        //Alternative von bgraf's solution on exercism.io
            
        //=> Enumerable
        //    .Range(1, max - 1)
        //    .Where(i => multiples.Any(j => j > 0 && i % j == 0))
        //    .Sum();


    }
}

