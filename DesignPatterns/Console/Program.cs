using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();

            dog.setName("Grover");

            System.Console.WriteLine($"My dog is called {dog.Name}");

        }
    }
}
