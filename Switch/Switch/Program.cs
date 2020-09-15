using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch dùng để chạy 1 trong các khối câu lệnh của nó 
            int x = 5;
            switch (x)
            {
                case 1:
                    Console.WriteLine("No.1");
                    break;
                case 2:
                    Console.WriteLine("No.2");
                    break;
                case 3:
                    Console.WriteLine("No.3");
                    break;
                case 4:
                    Console.WriteLine("No.4");
                    break;
                case 5:
                    Console.WriteLine("No.5");
                    break;
                default:
                    //Từ khóa mặc định là default trong trường hợp ko chạy khối câu lệnh điều kiện nào
                    //thì mặc định sẽ chạy vào câu lệnh default
                    Console.WriteLine("Default");
                    break;
            }
        }
    }
}
