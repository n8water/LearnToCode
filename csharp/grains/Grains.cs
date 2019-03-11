using System;
using System.Text.RegularExpressions;

public static class Grains
{
    public static ulong Square(int n)
    {
        ulong result = 0;
        double exponent = n - 1;

        if((exponent < 0) | (exponent > 63))
            throw new ArgumentOutOfRangeException();
        else
        {
            result = (ulong) Math.Pow(2, exponent);
        }
        return result;
    }

    public static ulong Total()
    {
        ulong total = 0;

        for (int i = 0; i < 65; i++)
        {
            total += (ulong) Math.Pow(2, (i - 1));
        }

        return total;
    }
}