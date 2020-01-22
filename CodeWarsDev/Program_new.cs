using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace CodeWarsDev
{
    class Program
    {
        static void Main(string[] args)
        {
            HighestLowest.HighAndLow("1 2 3");

            Console.ReadKey();
        }       
       
    }

    public static class HighestLowest
    {
<<<<<<< HEAD
        public static string HighAndLow(string numbers)
        {
            List<int> inputNumbers = new List<int>();

            var input = numbers.Split(' ');

            foreach(var x in input)
            {
                if(int.TryParse(x, out int i))
                {
                    inputNumbers.Add(i);
                }
            }

            return $"{inputNumbers.Max()} {inputNumbers.Min()}";
=======
        public static int MaxMultiply(int divisor, int bound)
        {
            //n is divisible by divisor
            //n is less than or equal to bound
            //n is greater than 0.
            int n = bound;
            
            while (n % divisor != 0)
                n--;

            return n; ;
>>>>>>> bcf207d51837992c50a7effeb12ee4fadf07e760
        }
    }

    [TestFixture]
    public class Tests
<<<<<<< HEAD
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighestLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
=======

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
>>>>>>> bcf207d51837992c50a7effeb12ee4fadf07e760
        }
    }
}