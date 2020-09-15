using System;

namespace Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Break and Continue được sử dụng trong vòng lặp trong trường hợp muốn thoát hoặc muốn nhảy qua 1 dòng lệnh
            //Break and continue on for loop
            for(int i=0; i<5; i++)
            {
                if (i == 3)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            for(int j=0; j<5; j++)
            {
                if(j == 3)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(j);
                }
            }

            //Break and continue on while loop
            int k = 0;
            while (k < 5)
            {
                if(k == 3)
                {
                    Console.WriteLine(k);
                    break;
                }
                k++;
            }
            int l = 0;
            while (l < 5)
            {
                if (l == 3)
                {
                    l++;
                    continue;
                }
                else
                {
                    Console.WriteLine(l);
                }
                l++;
            }
            Console.WriteLine("Hello World!");
        }
    }
}
