using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string dirty = string.Empty;
        string clean = string.Empty;

        foreach (char c in phoneNumber)
        {
            if (char.IsDigit(c))
                dirty += c;
        }

        if ((dirty.Length == 10)
            && (dirty[0] != '0')
            && (dirty[0] != '1')
            && (dirty[3] != '0')
            && (dirty[3] != '1'))
        {
            clean = dirty;
        }
        else if ((dirty[0] == '1')
                 && (dirty.Length == 11)
                 && (dirty[1] != '0')
                 && (dirty[1] != '1')
                 && (dirty[4] != '0')
                 && (dirty[4] != '1'))
        {
            clean = dirty.Substring(1);
        }
        else if (dirty.Length < 10)
        {
            throw new ArgumentException("phone number to short");
        }
        else
        {
            throw new ArgumentException("phone number too long");
        }

        return clean;
    }

    private static bool IsValid(string number)
    {
        bool isValid = false;

        return isValid;
    }
}