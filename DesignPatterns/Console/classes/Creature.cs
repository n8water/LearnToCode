using System;
using System.Collections.Generic;
using System.Text;

namespace Console.classes
{
    abstract public class Creature
    {
        protected string _name;
        protected int _weight;
        protected string _sound;

        public abstract void SetName(string newName);
        public abstract void SetWeight(int newWeight);
    }
}
