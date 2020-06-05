using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace CodeWarsDev
{
    class Program
    {
        static void Main()
        {
            var test = Kata.AbbrevName("Sabrina felder");
            Console.WriteLine(test);
            
        }       
       
    }

    public class Kata
    {
        public static string AbbrevName(string name)
        {
            var names = name.Split();
            string result = string.Empty;

            

            for (int i = 0; i < names.Length; i++)
            {
                result += names[i].Substring(0, 1);

                if (result.Length == 1)
                {
                    result += ".";
                }
            }

            return result.ToUpper();
        }
    }


}