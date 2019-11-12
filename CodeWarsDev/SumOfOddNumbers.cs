using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsDev
{
    public static class SumOfOddNumbers
    {
        public static long rowSumOddNumbers(long n)
        {
            long rows = n;
            long numberOfOddNumbers = Enumerable.Range(1, (int)n).Sum();
            
            var oddNumbers = Enumerable.Range(0, (int)(numberOfOddNumbers * 2)).Where(x => x % 2 != 0).Select(x => x).Cast<long>();

            Console.WriteLine(numberOfOddNumbers);

            Console.WriteLine(oddNumbers.Count());

            

            var reversedList = oddNumbers.Reverse();

            long result = oddNumbers.TakeLast((int)rows).Sum();


            return result;
        }
    }
}
