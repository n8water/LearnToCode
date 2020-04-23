using System;

namespace RepeatLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Variables

            var a = $"{ 400.ToString()     }";
            var b = $"{ false.ToString() }";
            var b1 = $"{ false }";
            var c = true;

            Console.WriteLine("a is " + a);
            Console.WriteLine("b is " + b);
            Console.WriteLine("b1 is " + b1);
            Console.WriteLine("c is " + c.ToString() );
            Console.WriteLine("c is " + c );

        }
    }
}
