using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Dog : IAnimal
    {
        public void AnimalSound()
        {
            Console.WriteLine("wof wof");
        }

        public void Run()
        {
            Console.WriteLine("4 chân");
        }
    }
}
