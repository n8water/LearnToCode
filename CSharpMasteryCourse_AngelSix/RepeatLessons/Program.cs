using System;

namespace RepeatLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "WhileLoop";

            int[] nums = new int[10];
            int i = 0;

            while( i < nums.Length)
            {
                nums[i] = i;
                if (i == 8) { Console.Write(" | Skipped"); }
                else
                {
                    Console.Write(" | " + nums[i]);
                }
                i++;
            }

            Console.WriteLine("\n\n");

            do
            {
                i--;
                if (i == 8) { Console.Write(" | Skipped"); continue; }
                if (i == 3) { Console.Write(" | Done"); break; }
                Console.Write(" | " + i);
            }
            while (i > 0);
            Console.ReadKey();
        }

        #region repetition
        //{
        //    Console.WriteLine("Hello World!");

        //    // Variables

        //    var a = $"{ 400.ToString()     }";
        //    var b = $"{ false.ToString() }";
        //    var b1 = $"{ false }";
        //    var c = true;

        //    Console.WriteLine("a is " + a);
        //    Console.WriteLine("b is " + b);
        //    Console.WriteLine("b1 is " + b1);
        //    Console.WriteLine("c is " + c.ToString() );
        //    Console.WriteLine("c is " + c );

        //}
        #endregion repetition
    }
}
