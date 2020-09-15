using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính đóng gói giúp che đi những dữ liệu nhạy cảm (private) mà vẫn có thể thao tác trên chúng
            /*Trong 1 số trường hợp chúng ta sẽ cần truy suất dữ liệu trên các
             *trường khai báo private thì chúng ta sử dụng Encapsulation*/
            Car Mustang = new Car();
            Mustang.Model = "Mustang";
            Console.WriteLine(Mustang.Model);

            //Thuộc tính tự động giảm thiểu dòng code
            Mustang.Color = "White";
            Console.WriteLine(Mustang.Color);
        }
    }
}
