using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính kế thừa là khả năng kế thừa lại các thuộc tính và các trường từ lớp cha sang lớp con
            //Lớp kế thừa chia làm 2 loại: 
            //Lớp cha (Base class): lớp được kế thừa
            //Lớp cha (Devired class): lớp kế thừa
            //Kế thừa giúp việc sử dụng lại các trường, phương thức và tối ưu hóa code hơn
            Dog dog = new Dog("wof wof");
            Cat cat = new Cat("meao meao");
            Console.WriteLine(dog.animalSound + "\b" + cat.animalSound);
            dog.sleep();
            cat.sleep();

        }
    }
}
