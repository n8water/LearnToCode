using System;
using System.Collections.Generic;

public static class AllYourBase
{
    private static int inputValue;
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        CalculateInputValue(inputBase, inputDigits);
        ChangeBase(outputBase, inputValue);
        throw new NotImplementedException("Please implement this function");
    }

    private static void ChangeBase(int outputBase, int inputValue)
    {
        int input = inputValue;
        int temp = 0;
        int counter = 0;
        int[] outputValues = new int[]();
        Dictionary<int, int> values = new Dictionary<int, int>();

        while(input > 0)
        {
            while(temp < input)
            {
                temp = (int)Math.Pow((double)outputBase, (double)counter);
                counter++;
            }

            values.Add(counter, 1);
            input -= temp;
            counter = 0;
            temp = 0;
        }






    }

    private static void CalculateInputValue(int inputBase, int[] inputDigits)
    {
        int numberOfInputDigits = inputDigits.Length - 1;
        inputValue = 0;

        foreach (var digit in inputDigits)
        {
            inputValue += digit * (int)Math.Pow((double)inputBase, (double)numberOfInputDigits);
            numberOfInputDigits--;
        }
    }

}