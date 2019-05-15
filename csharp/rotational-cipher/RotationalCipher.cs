using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        string result = string.Empty;

        foreach(char c in text)
            result += Encrypt( c, shiftKey);
        
        return result;
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