using System;

namespace User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Nhập liệu từ bàn phím (ReadLine) là 1 method của Console
            được dùng để nhập dữ liệu từ bàn phím người dùng*/

            string name = Console.ReadLine();
            Console.WriteLine("Your name :" + name);
        }
    }
}
