using System;

namespace Enum
{
    class Program
    {
        //Enum trong 1 class
        enum Level
        {
            Low,
            Medium,
            Hight
        }
        static void Main(string[] args)
        {
            //Là 1 lớp đại diện lưu trữ 1 nhóm các hằng số
            Level myLevel = Level.Low;
            Console.WriteLine(myLevel);

            //Giá trị của 1 hằng số trong class enum
            int myNum = (int)Level.Medium;
            Console.WriteLine(myNum);

            //Sử dụng swicth để thực thi câu lệnh với enum
            switch (myLevel)
            {
                case Level.Low:
                    Console.WriteLine(myLevel);
                    break;
                case Level.Medium:
                    Console.WriteLine(myLevel);
                    break;
                case Level.Hight:
                    Console.WriteLine(myLevel);
                    break;
            }
        }
    }
}
