using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Bird : IAnimal , IFeatherAnimals
    {
        public void AnimalSound()
        {
            Console.WriteLine("quac quac");
        }

        public void Run()
        {
            Console.WriteLine("2 cánh");
        }
    }
}
