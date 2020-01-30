using Console.classes;
using System;

namespace Console
{
    class Program
    {
        int justANum = 10;
        static void Main(string[] args)
        {
            Dog fido = new Dog();

            fido.SetName("Fido");
            System.Console.WriteLine(fido.Name);

            fido.DigHole();

            fido.SetWeight(-1);

            // pass by value, Original is not affected by changes in methods

            int randNum = 10;
            fido.ChangeVar(randNum);

            System.Console.WriteLine("randNum after method call: " + randNum);

            // objects are passed by reference to the original object
            // changes in methods do effect the object

            changeObjectName(fido);
            System.Console.WriteLine("Dog name after method call " + fido.Name);


            // create a Dog and a Cat object with the super class
            // but Dog and Cat reference Type
            Animal doggy = new Dog();
            Animal kitty = new Cat();

            System.Console.WriteLine("Doggy says: " + doggy.Sound);
            System.Console.WriteLine("Kitty says: " + kitty.Sound + "\n");

            // Make arrays of  Animals and everything just works

            Animal[] animals = new Animal[4];
            animals[0] = doggy;
            animals[1] = kitty;

            System.Console.WriteLine("Doggy says: " + animals[0].Sound);
            System.Console.WriteLine("Kitty says: " + animals[1].Sound + "\n");

            // Sends Animal object for processing in a method
            SpeakAnimal(doggy);

            // You can't reference methods, of fields that aren't in Animal
            // if you do, you'll have to cast to the required object
            ((Dog)doggy).DigHole();

            // access the variable from outside main
            // can't use non static variables or methods in a static function/method
            // System.Console.WriteLine(justANum);
            // SayHello();
            
            // you cannot call a private method
            // fido.BePrivate();

            fido.AccessPrivate();

            // Creating a Giraffe from an abstract class

            Giraffe giraffe = new Giraffe();

            giraffe.SetName("Frank");

            System.Console.WriteLine("The Giraffe is called " + giraffe.Name);


        }

        // Receives Animal object and makes them speak

        public static void SpeakAnimal(Animal randAnimal)
        {
            System.Console.WriteLine("Animal says: " + randAnimal.Sound);
        }

        // Non static method to demonstrate you can't call it from inside a static method
        public void SayHello()
        {
            System.Console.WriteLine("Hello");
        }

        public static void changeObjectName(Dog fido)
        {
            fido.SetName("Marcus");
        }
    }
}
