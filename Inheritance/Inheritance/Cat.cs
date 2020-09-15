using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat:Animals
    {
        public string animalSound;

        public Cat(string animalSound)
        {
            this.animalSound = animalSound;
        }
    }
}
