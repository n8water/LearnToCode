using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string toCheck = string.Empty;
        string clean = string.Empty;

        foreach (char c in phoneNumber)
        {
            if (char.IsDigit(c))
                toCheck += c;
        }

        //Check length
        if(toCheck.Length < 12 && toCheck.Length > 9)
            CheckValidity(toCheck);
        else
        {
            throw new ArgumentException("Phone number length is invalid");
        }

        #region Quick and dirty solution
        //Quick and dirty solution
        //if ((dirty.Length == 10)
        //    && (dirty[0] != '0')
        //    && (dirty[0] != '1')
        //    && (dirty[3] != '0')
        //    && (dirty[3] != '1'))
        //{
        //    clean = dirty;
        //}
        //else if ((dirty[0] == '1')
        //         && (dirty.Length == 11)
        //         && (dirty[1] != '0')
        //         && (dirty[1] != '1')
        //         && (dirty[4] != '0')
        //         && (dirty[4] != '1'))
        //{
        //    clean = dirty.Substring(1);
        //}
        //else if (dirty.Length < 10)
        //{
        //    throw new ArgumentException("phone number to short");
        //}
        //else
        //{
        //    throw new ArgumentException("phone number too long");
        //} 
        #endregion

        return clean;
    }

    private static void CheckValidity(string numberToCheck)
    {
        if (numberToCheck.Length == 11 && numberToCheck[0] == '1')
            numberToCheck = numberToCheck.Substring(1);

        if((numberToCheck[0] != '0') && (numberToCheck[3] != '1'))
        {
            clean = numberToCheck;
        }
    }
}
