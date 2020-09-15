using System;

namespace Math_C
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Math là 1 class trong System cung cấp các method để sử dụng trong các nhiệm vụ toán học*/
            //Tìm max min trong 2 số
            int x = 5;
            int y = 10;
            Console.WriteLine(Math.Max(x, y));

            //Căn bậc 2 của 1 biến
            Console.WriteLine(Math.Sqrt(y));

            //Giá trị tuyệt đối của 1 biến hoặc giá trị
            Console.WriteLine(Math.Abs(-10));

            //Làm tròn 1 số thập phân với giá trị gần nhất
            Console.WriteLine(Math.Round(6.5));

            
        }
    }
}
