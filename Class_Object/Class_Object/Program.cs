using System;

namespace Class_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Class/Object tạo class object bên class Car
             * Tạo nhiều class gồm class Animals và class Program*/

            /*Sử dụng nhiều lớp để dễ phân bổ các lớp giúp giảm 
            thiểu việc code quá dài trong 1 class dễ cho việc bảo trì code*/
            Dog dog = new Dog();
            dog.color = "Meao meao";
            Console.WriteLine(dog.color);
        }
    }
}
