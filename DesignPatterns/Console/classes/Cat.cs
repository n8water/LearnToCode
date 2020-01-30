using System;
using System.Collections.Generic;
using System.Text;

namespace Console.classes
{
    class Cat : Animal
    {
        #region C'tor
        public Cat()
        {
            SetSound("Meow");
        }
        #endregion C'tor

        internal void Attack()
        {
            // Do stuff that can never change
        }

        public static readonly double FavNumber = 3.14;
       
    }
}
