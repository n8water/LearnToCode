using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
        // declare and initialize variables
        var result = new List<string>();
        Dictionary<string, string> Proteins = new Dictionary<string, string>();

        // Fill dictionary
        Proteins.Add("AUG", "Methionine");
        Proteins.Add("UUU", "Phenylalanine");
        Proteins.Add("UUC", "Phenylalanine");
        Proteins.Add("UUA", "Leucine");
        Proteins.Add("UUG", "Leucine");
        Proteins.Add("UCU", "Serine");
        Proteins.Add("UCC", "Serine");
        Proteins.Add("UCA", "Serine");
        Proteins.Add("UCG", "Serine");
        Proteins.Add("UAU", "Tyrosine");
        Proteins.Add("UAC", "Tyrosine");
        Proteins.Add("UGU", "Cysteine");
        Proteins.Add("UGC", "Cysteine");
        Proteins.Add("UGG", "Tryptophan");
        Proteins.Add("UAA", "STOP");
        Proteins.Add("UAG", "STOP");
        Proteins.Add("UGA", "STOP");

        // check substrings
        while(strand.Length >= 3)
        {
            string temp = strand.Substring(0, 3);
            if (Proteins[temp] != "STOP")
                result.Add(Proteins[temp]);
            else
                break;
            strand = strand.Substring(3);

        }

        // return result as array
        return result.ToArray();
    }
}