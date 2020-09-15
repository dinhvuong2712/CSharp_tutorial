using System;
using System.IO;
namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Các lớp trong không gian system.IO cung cấp cho chung ta các lớp và phương thức giúp chúng ta thao tác với tệp
            //Có rất nhiều phương thức trong class FIle
            //Phương thức viết tệp tin
            string myString = "Vuong";
            File.WriteAllText("first.txt", myString);

            string txtString = File.ReadAllText("first.txt");
            Console.WriteLine(txtString);
        }
    }
}
