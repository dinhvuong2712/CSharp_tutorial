using System;

namespace Class_Object
{
    class Car
    {
        //Lớp cha chứa các thuộc tính chung của các đối tượng
        public string color = "white";
        static void Main(string[] args)
        {
            //Khai báo các đối tượng khác nhau;
            //Tạo nhiều đối tượng có cùng các thuộc tính chung
            Car mustang = new Car();
            Car ferari = new Car();
            Console.WriteLine(mustang.color);
            Console.WriteLine(ferari.color);
        }
    }
}
