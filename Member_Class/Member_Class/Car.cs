using System;
using System.Collections.Generic;
using System.Text;

namespace Member_Class
{
    class Car
    {
        //Member class là các thành phần của 1 class chứa các tính chất và hành động của 1 đối tượng
        public string model;
        public string color;
        static void Main(string[] args)
        {
            Car carMustang = new Car();
            carMustang.model = "Mustang";
            carMustang.color = "black";
            Console.WriteLine(carMustang.model +" "+ carMustang.color);

            Car carFerari = new Car();
            carFerari.model = "Ferari";
            carFerari.color = "red";
            Console.WriteLine(carFerari.model + " " + carFerari.color);
        }
    }
}
