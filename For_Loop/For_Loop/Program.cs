using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loop là vòng lặp biết trước số lần lặp và chạy khối câu lệnh bên trong
            //Vòng lặp gồm có 3 phần trong ngoặc tròn
            //Phần đầu được vòng lặp chạy 1 lần đầu tiên
            //phần 2 là phần điều kiện của vòng lặp
            //Phần 3 là phần chạy liên tục đến khi vòng lặp dừng
            string[] arrray = { "Dang", "Dinh", "Dinh" }; 
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(arrray[i]);
            }
            
            //Vòng lặp foreach sử dụng dành riêng co mảng tiện lợi cho việc truy suất mảng
            foreach(string items in arrray)
            {
                Console.WriteLine(items);
            }
        }
    }
}
