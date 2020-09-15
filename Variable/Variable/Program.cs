using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Biến là 1 vùng chứa lưu trữ dữ liệu được khai báo với 
            nhiều kiểu dữ liệu khác nhau và đc đặt tên khác nhau tùy vào dữ liệu mình muốn gán*/
            int myNum = 10;
            double myDouble = 9.99;
            char myLetter = 'V';
            string myText = "Vuong";
            Console.WriteLine(myNum + "\n" + myDouble + "\n" + myLetter + "\n" + myText);

            //Ngoài ra còn có hằng số dùng trong trường hợp muốn tạo 1 vùng chứa ko gán lại được
            const int number = 4;
            Console.WriteLine(number);
        }
    }
}
