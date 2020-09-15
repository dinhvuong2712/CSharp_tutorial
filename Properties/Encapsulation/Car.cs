using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Car
    {
        private string model;
        private string color;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color { get; set; }
    }
}
