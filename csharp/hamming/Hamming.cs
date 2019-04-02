using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {        
        if (firstStrand.Length != secondStrand.Length)
            throw new ArgumentException("Strands differ in length");
        
        //Version with LINQ
        var distance = firstStrand.Zip(secondStrand, (a, b) => a != b ? 1 : 0);
                
        return distance.Sum();
    }
}