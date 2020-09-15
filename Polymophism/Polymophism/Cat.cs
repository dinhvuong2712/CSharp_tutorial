using System;
using System.Collections.Generic;
using System.Text;

namespace Polymophism
{
    class Cat : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Meao meao");
        }
    }
}
