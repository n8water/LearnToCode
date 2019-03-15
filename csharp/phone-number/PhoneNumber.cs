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

        if (toCheck.Length < 12 && toCheck.Length > 9)
            clean = CheckValidity(toCheck);
        else
        {
            throw new ArgumentException("Phone number length is invalid");
        }
       
        return clean;
    }

    private static string CheckValidity(string numberToCheck)
    {
        string validNumber = string.Empty;

        if (numberToCheck.Length == 11 && numberToCheck[0] == '1')
            numberToCheck = numberToCheck.Substring(1);
        else if(numberToCheck.Length == 11)
            throw new ArgumentException("Number is invalid");


        if ((numberToCheck[0] != '0') &&
            (numberToCheck[0] != '1') &&
            (numberToCheck[3] != '0') &&
            (numberToCheck[3] != '1'))
        {
            validNumber = numberToCheck;
        }
        else
        {
            throw new ArgumentException();
        }

        return validNumber;
    }
}
