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
        public static int Gimme(double[] inputArray)
        {
            var input = inputArray.ToList<double>();

            var temp = inputArray.ToList<double>().Sort();
            

            return 0;




            
        }
    }
    #endregion

    #region Tests
    [TestFixture]
    public class Test
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(0, Kata.Gimme(new double[] { 2, 3, 1 }));
            Assert.AreEqual(1, Kata.Gimme(new double[] { 5, 10, 14 }));
        }
    }
    #endregion
}