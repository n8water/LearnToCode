using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExamRef70_483
{
    public static class Chapter1
    {
        public static void Task1()
        {
            Console.WriteLine("Starting Task 1");
            Thread.Sleep(2000);
            Console.WriteLine("Ending Task 1");
        }

        public static void Task2()
        {
            Console.WriteLine("Starting Task 2");
            Thread.Sleep(1000);
            Console.WriteLine("Ending Task 2");
        }

        public static void Task3()
        {
            Console.WriteLine("Starting Task 3");
            Thread.Sleep(1500);
            Console.WriteLine("Ending Task 3");
        }
    }
}
