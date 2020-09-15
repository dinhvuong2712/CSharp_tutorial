using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lớp trừu tượng dùng để ẩn các thông tin nhất định  và hiển thị các thông tin cần thiết cho người dùng
            //lớp trừu tượng không thể khởi tạo đối tượng chỉ đc sử dụng thông qua lớp kế thừa
            //phương thức trừu tượng không có phần thân để sử dụng nó cần thông qua lớp kế thừa
            Dog dog = new Dog();
            Cat cat = new Cat();
            dog.Sound();
            cat.Sound();
        }
    }
}
