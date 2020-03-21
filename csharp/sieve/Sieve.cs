using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        //Variables
        var myArray = new int[limit + 1];

        // Check if Limit < 2
        if(limit < 2)
            throw new ArgumentOutOfRangeException();

        // Else if Limit >= 2
        for (int i = 0; i <= limit; i++)
        {
            if (i < 2)
            {
                myArray[i] = 1;
            }
            else if (myArray[i] != 1)
            {
                SetValue(i);
            }
        }
        
        return GenerateResult(myArray);


        #region Helper Methods
        void SetValue(int i)
        {
            int n = 2;

            while (i * n <= limit)
            {
                myArray[i * n] = 1;
                n++;
            }
        }

        int[] GenerateResult(int[] input)
        {
            if (input is object)
            {
                int counter = 0;
                var temp = input.ToList();
                List<int> result = new List<int>();

                foreach(var t in temp)
                {                    
                    if(t == 0)
                    {
                        result.Add(counter);                        
                    }
                    counter++;
                }

                return result.ToArray();
            }
            else
                throw new ArgumentNullException();
        }
        #endregion Helper Methods
    }
}
