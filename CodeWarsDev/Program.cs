using System;
using NUnit.Framework;
using System.Linq;

namespace CodeWarsDev
{
    class Program
    {
        static void Main(string[] args)
        {


        }       
       
    }

    #region Current Kata
    public class Kata
    {
        public static int MaxMultiply(int divisor, int bound)
        {
            //n is divisible by divisor
            //n is less than or equal to bound
            //n is greater than 0.
            int n = bound;
            
            while (n % divisor != 0)
                n--;

            return n; ;
        }
    }
    #endregion

    #region Tests
    [TestFixture]
    public class Tests

    {
        [TestCase(2, 7, 6)]
        [TestCase(3, 10, 9)]
        [TestCase(7, 17, 14)]
        public void SmallNumbers(int divisor, int bound, int ex)
        {
            Assert.That(Kata.MaxMultiply(divisor, bound), Is.EqualTo(ex));
        }
        [TestCase(10, 50, 50)]
        [TestCase(37, 200, 185)]
        [TestCase(7, 100, 98)]
        public void LargeNumbers(int divisor, int bound, int ex)
        {
            Assert.That(Kata.MaxMultiply(divisor, bound), Is.EqualTo(ex));
        }
    }
    #endregion
}