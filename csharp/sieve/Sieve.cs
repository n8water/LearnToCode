using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        //int[] result = new int[0];
        IEnumerable<int> myRange = Enumerable.Range(2, limit - 1);
        IEnumerable<int> results = new List<int>();

        for(int i = 2; i <= limit; i++)
        {

            results.Append(i);
            myRange.
        }


        if(limit < 2)
            throw new ArgumentOutOfRangeException();

       var result = myRange.Where(x => x).Select(x);



        throw new NotImplementedException("You need to implement this function.");
    }
}