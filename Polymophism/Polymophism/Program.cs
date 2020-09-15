using System;

namespace Polymophism
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tính đa hình cũng dựa trên tính kế thừa , 
            tính đa hình sử dụng các phương thức giống nhau nhưng 
            khác về cách thức hành động giữa các class*/
            //Phù hợp cho việc tái sử dụng mã cho các lớp con
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();
            animal.animalSound();
            cat.animalSound();
            dog.animalSound();
        }
    }
}
