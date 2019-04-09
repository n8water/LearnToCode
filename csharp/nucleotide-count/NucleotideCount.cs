using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IReadOnlyDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleotides = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0,
        };

        foreach (char c in sequence)
        {
            if (nucleotides.ContainsKey(c))
                nucleotides[c]++;
            else
                throw new ArgumentException();
        }

        return (IReadOnlyDictionary<char, int>)nucleotides;
    }

    
}