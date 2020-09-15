using System;

namespace Method_Overloading
{
    class Program
    {
        static int Method(int x, int y)
        {
            return x + y;
        }
        static double Method(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            /*Method overloading dùng để nạp chồng phương thức thay vì gọi
            nhiều phương thức thì ta có thể gọi nhiều phương thức cùng tên với các tham số khác nhau*/

            int methodInt = Method(3, 5);
            double methodDouble = Method(3.4,4.5);
            Console.WriteLine(methodInt + '\n' + methodDouble);
        }
    }
}
