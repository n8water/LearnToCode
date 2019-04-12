using System;
using System.Collections.Generic;
using System.Linq;

public static class ArmstrongNumbers
{


    public static bool IsArmstrongNumber(int number)
    {
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