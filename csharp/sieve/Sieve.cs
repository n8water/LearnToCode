using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        //Variables
        var myArray = new int[limit];


        //Work
        if(limit < 2)
            throw new ArgumentOutOfRangeException();



        //for (int i = 0; i <= limit; i++)
        //{
        //    if (i < 2)
        //    {
        //        myArray[i] = 1;
        //    }
        //    else if (myArray[i] != 1)
        //    {
        //        SetValue(i);
        //    }

        //    return GenerateResult(myArray);
        //}

        //throw new NotImplementedException("You need to implement this function.");

        //void SetValue(int i)
        //{
        //    int n = 2;

        //    while(i * n <= limit)
        //    {
        //        myArray[i * n] = 1;
        //        n++;
        //    }
        //}

        //int[] GenerateResult(int[] input)
        //{
        //    if(input is object)
        //    {
        //        var searchList = input.ToList<int>();

        //        var results = searchList.Where(x => x == 0).Select(searchList.);

        //    }

        throw new ArgumentNullException();
    }
}
