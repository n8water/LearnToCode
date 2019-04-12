using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{


    public static bool IsArmstrongNumber(int number)
    {
        //bool _isArmstrongNumber = false;
        //List<int> digits = new List<int>();
        //int exponent = 0;
        //int temporaryNumber = number;

        //if(temporaryNumber<0)
        //    throw new ArgumentException();

        //while (temporaryNumber>0)
        //{        
        //    if(temporaryNumber > 9)
        //    {
        //        digits.Add(temporaryNumber%10);
        //        temporaryNumber = temporaryNumber / 10;            
        //    }
        //    else
        //    {
        //        digits.Add(temporaryNumber);
        //        temporaryNumber = 0;
        //    }
        //}

        //exponent = digits.Count;

        //foreach (int digit in digits)
        //{
        //    temporaryNumber += (int) Math.Pow(digit, exponent);
        //}

        //if(temporaryNumber == number)
        //    _isArmstrongNumber = true;

        //return _isArmstrongNumber;   


        //Second attempt

        int temp = number;
        int exponent = (int)number.ToString().Length;
        int result = 0;

        while (temp>0)
        {
            result += (int) Math.Pow(temp%10, exponent);
            temp /= 10;
        }

        return result == number;
    }
}