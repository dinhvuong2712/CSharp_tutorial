using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface là 1 lớp trừu tượng toàn phần và tất cả đều là phương thức và thuộc tính trừu tượng
            //Tuy C# ko hỗ trợ đa kế thừa nhưng có hỗ trợ nhiều interface
            //Interface chỉ chứa thuộc tính phương thức chứ ko chứa trường
            //Cũng giống lớp trừu tượng interface ko thể khởi tạo đối tượng

            Dog dog = new Dog();
            Bird bird = new Bird();
            dog.AnimalSound();
            dog.Run();
            bird.AnimalSound();
            bird.Run();

        }
    }
}
