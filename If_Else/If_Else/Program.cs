using System;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            //If else dùng để xét điều kiện và chạy các hành động trong ngoặc của các toán tử logic thông thường
            //Điều kiện If nếu điều kiện của if trả về true sẽ chạy hành động trong ngoặc nhọn
            int x = 10;
            if (x > 5)
            {
                Console.WriteLine("Điều kiện if");
            }else if(x == 10)
            {
                //Điều kiện else if xét tiếp điều kiện nếu có
                Console.WriteLine("Điều kiện else if");
            }
            else
            {
                //Điều kiện else nếu if sai sẽ nhảy sang hành động của else trong trường hợp ko còn điều kiện nào được xét
                Console.WriteLine("Điều kiện else");
            }

            //Ngoài ra còn có toán tử bậc 3 (short-hand if else) được sử dụng trong các điều kiện đơn giản
            bool myBoolean = (x > 10) ? true : false;
            Console.WriteLine("Toán tử bậc 3 : " + myBoolean);

        }
    }
}
