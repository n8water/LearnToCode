using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        //working solution
        //List<string> slices = new List<string>();
        //int runs = numbers.Length - sliceLength;

        if (numbers.Length < sliceLength || sliceLength<=0)
            throw new ArgumentException("Invalid input");

        //else
        //{
        //    for (int i = 0; i <= runs; i++)
        //    {
        //        slices.Add(numbers.Substring(i, sliceLength));
        //    }
        //}

        //return slices.ToArray();

        //Alternative with Linq
       
        var slices = numbers.Select((x,i) => i<=(numbers.Length-sliceLength) && (i+sliceLength)<=numbers.Length ? numbers.Substring(i, sliceLength): string.Empty);
        var validSlices = slices.Where(x => x.Length>0).Select(x => x);         
        return validSlices.ToArray();
    }
}