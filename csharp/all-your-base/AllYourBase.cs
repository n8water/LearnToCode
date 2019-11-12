using System;
using System.Collections.Generic;

public static class AllYourBase
{
    static int decimalInput = 0;
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if ((inputBase <= 1) || (outputBase <= 1))
            throw new ArgumentException();

        InputToDecimal(inputBase, inputDigits);
          

        return ConvertInput(decimalInput, outputBase);
    }

    //private methods
    private static void InputToDecimal(int inputBase, int[] inputDigits)
    {
        int input = 0;
        int counter = inputDigits.Length;
        
        foreach(int i in inputDigits)
        {
            if (i >= 0 && i < inputBase)
            {
                input += (i * (int)Math.Pow((double)inputBase, (double)counter - 1));
                counter--;
            }
            else
                throw new ArgumentException();
        }

        decimalInput = input;
    }

    private static int[] ConvertInput(int decimalInput, int outputBase)
    {
        int temp = decimalInput;
        var output = new List<int>();

        while(temp > 0)
        {
            output.Add(temp % outputBase);
            temp = temp / outputBase;
        }

        if (output.Count == 0)
            return new int[1] { 0 };

        output.Reverse();
        return output.ToArray();
    }
}