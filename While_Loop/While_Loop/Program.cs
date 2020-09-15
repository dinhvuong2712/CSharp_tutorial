using System;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop là vòng lặp ko biết trước số lần lặp miễn là đúng với điều kiện
            //Vòng lặp while xét điều kiện trước khi lặp
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("No." + i);
                i++;
            }

            //Vòng lặp do while sẽ chạy trước 1 lần sau đó mới xét điều kiện
            do
            {
                Console.WriteLine("No." + i);
                i++;
            } while (i < 5);
        }
    }
}
