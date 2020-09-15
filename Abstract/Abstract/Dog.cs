using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("wof wof");
        }
    }
}
