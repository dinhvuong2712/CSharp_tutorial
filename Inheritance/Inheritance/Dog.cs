using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Dog:Animals
    {
        public string animalSound;

        public Dog(string animalSound)
        {
            this.animalSound = animalSound;
        }

    }
}
