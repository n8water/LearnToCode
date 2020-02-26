using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleCipher
{
    private int lower = 97;
    private int upper = 122;
    private readonly List<char> shift = Enumerable.Range('a', 26).Select(x => (char)x).ToList();
    private string _key = string.Empty;

    public SimpleCipher()
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public SimpleCipher(string key)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public string Key
    {
        get
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }

    public string Encode(string plaintext)
    {        
        string encoded = string.Empty;

        foreach(var c in plaintext)
        {
            int cvalue = (char)c;
            int shift = 0;

            if(cvalue + shift > upper)
            {
                encoded += (char)(cvalue + shift - 26);
            }
            else
            {
                encoded += (char)(cvalue + shift);
            }
        }

        return encoded;
    }

    public string Decode(string ciphertext)
    {
        string decoded = string.Empty;

        foreach(var c in ciphertext)
        {
            int cvalue = (char)c;
            int shift = 0;

            if(cvalue - shift < lower)
            {
                decoded += (char)(cvalue - shift + 26);
            }
        }

        return decoded;
    }
}