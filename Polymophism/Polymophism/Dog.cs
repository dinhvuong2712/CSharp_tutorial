using System;
using System.Collections.Generic;
using System.Text;

namespace Polymophism
{
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Wof wof");
        }
    }
}
