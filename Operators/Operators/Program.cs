using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operators là toán tử thường được sử dụng trên các biến và các phần tử
            //Toán tử chia ra nhiều loại:

            int x = 6;
            int y = 8;
            string myString = "Dang Dinh Vuong";

            //Toán tử số học dùng để tính toán giữa các phần tử hoặc cá biến
            Console.WriteLine(x + y);//Thực hiện phép tính x+y;
            Console.WriteLine(x - y);//Thực hiện phép tính x-y;
            Console.WriteLine(x * y);//Thực hiện phép tính x*y;
            Console.WriteLine(x / y);//Thực hiện phép tính x/y;

            //Toán tử chuyển nhượng (gán) dùng để gán dữ liệu vào biến thông qua mảng tùy theo phép gán
            Console.WriteLine(x += 5);//x = x+5;
            Console.WriteLine(x -= 5);//x = x+5;
            Console.WriteLine(x *= 5);//x = x+5;
            Console.WriteLine(x /= 5);//x = x+5;
            Console.WriteLine(x %= 5);//x = x%5;
            //Dưới đây là các phép gán với dữ liệu dạng bit
            Console.WriteLine(x &= 5);//x = x&5;
            Console.WriteLine(x |= 5);//x = x|5;
            Console.WriteLine(x >>= 5);//x = x >> 5
            Console.WriteLine(x <<= 5);//x = x << 5

            //Toán tử so sánh dùng để so sánh giữa 2 giá trị thường sẽ trả về giá trị boolean
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x <= y);
            Console.WriteLine(x >= y);
            Console.WriteLine(x > y);
            Console.WriteLine(x < y);

            //Toán tử logic dùng để xác định logic giữa các giá trị
            Console.WriteLine(x > 1 && x < y);
            Console.WriteLine(x < 1 || x > y);
            Console.WriteLine(!(x > 1 || x < y));
        }
    }
}
