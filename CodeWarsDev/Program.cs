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
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighestLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}