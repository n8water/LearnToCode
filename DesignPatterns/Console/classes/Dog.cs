using System;
using System.Collections.Generic;
using System.Text;

namespace Console.classes
{
    class Dog : Animal
    {
        public void DigHole()
        {
            System.Console.WriteLine("Dug a hole");
        }

        public void ChangeVar(int randNum)
        {
            randNum = 12;

            System.Console.WriteLine($"randNum in method value: {randNum}");
        }

        /*This private method can only be accessed through using other
        methods in the class */

        private void bePrivate()
        {
            System.Console.WriteLine("In a private method");
        }

        public void accessPrivate()
        {
            bePrivate();
        }

        //The constructor initializes all objects
        public Dog()
        {

        }

    }
}
