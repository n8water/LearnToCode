using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int temp = number;
        int i = 1;
        int sum = 0;

        if (number < 0 | number == 0)
            throw new ArgumentOutOfRangeException("Not a natural number");
        

        while(i<=number/2)
        {
            if(temp % i == 0)
            {
                if (temp == number)
                    sum += i;
                else
                {
                    temp = temp / i;
                    sum += temp + i;
                }
            }          
            i++;
        };

        if (sum == number)
            return Classification.Perfect;
        else if (sum < number)
            return Classification.Deficient;
        else
            return Classification.Abundant;        
    }
}
