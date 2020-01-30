using System;
using System.Collections.Generic;
using System.Text;

namespace Console.classes
{
    public class Giraffe : Creature
    {
        //private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public override void SetName(string newName)
        {
            _name = newName;
        }

        public override void SetWeight(int newWeight)
        {
            if(newWeight > 0)
            {
                _weight = newWeight;
            }
            else
                System.Console.WriteLine("Weight must be bigger than 0");
        }
    }
}
