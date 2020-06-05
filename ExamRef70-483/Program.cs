using System;
using System.Threading.Tasks;


namespace ExamRef70_483
{
    class Program
    {
        static void Main(string[] args)
        {            
            Parallel.Invoke(() => Chapter1.Task1(), () => Chapter1.Task2(), () => Chapter1.Task3());
        }
    }
}
