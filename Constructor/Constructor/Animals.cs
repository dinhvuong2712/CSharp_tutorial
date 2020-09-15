using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Animals
    {
        //Hàm khởi tạo có tham số giúp khởi tạo các trường dữ liệu cho các đối tượng khác nhau
        public string animalSound;
        public Animals(string animalSound)
        {
            this.animalSound = animalSound;
        }
        /*static void Main(string[] args)
        {
            Animals dog = new Animals("wof wof");
            Console.WriteLine(dog.animalSound);
        }*/
    }
}
