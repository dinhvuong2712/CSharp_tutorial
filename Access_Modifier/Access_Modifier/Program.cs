using System;

namespace Access_Modifier
{
    class Program
    {

        /*Access Modifier được hiểu là phân quyền truy cập
        tùy thuộc vào trường dữ liệu và tính bảo mật của dữ liệu*/
        //Public Modifire ở class Car
        //Private Modifire ở class Animals

        static void Main(string[] args)
        {
            Car mustang = new Car();
            Console.WriteLine(mustang.model);
            Animals animals = new Animals();
            Console.WriteLine(animals.animalSound);//Trường dữ liệu được set quyền truy cập là private nên ko thể truy cập từ class khác
        }
    }
}
