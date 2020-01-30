using System;
using System.Collections.Generic;
using System.Text;

namespace Console.classes
{
    public interface ILiving
    {
        public void SetName(string newName);

        public void SetHeight(double newHeight);

        public void SetWeight(double newWeight);

        public void SetFavFood(string newFood);

        public void SetSpeed(double newSpeed);

        public void SetSound(string newSound);
    }
}
