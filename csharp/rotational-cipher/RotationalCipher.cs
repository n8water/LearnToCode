using System;
using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        StringBuilder result = new StringBuilder();

        foreach(char c in text)
            result.Append(Encrypt( c, shiftKey));
        
        return result.ToString();
    }

    private static char Encrypt(char c, int key)
    {
        if(!char.IsLetter(c))
            return c;

        //Is c upper or lower?
        char b = char.IsUpper(c) ? 'A' : 'a';
        
        return (char)((((c+key)-b) % 26) + b);
    }
}