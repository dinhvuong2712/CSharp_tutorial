using System;

namespace Types_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ép kiểu là khi bạn ép dữ liệu của 1 kiểu sang 1 kiểu dữ liệu khác
            //Có 2 loại ép kiểu ép ngầm và ép rõ ràng

            /*Ép ngầm được tự động ép khi dữ liệu muốn chuyển được
            chuyển từ loại có kích thước nhỏ sang loại có kích thước lớn hơn*/
            int myNumber = 4;
            double myDouble = myNumber;
            Console.WriteLine("Ép kiểu ngầm định: "+ myNumber + " : " + myDouble);

            /*Và ngược lại với chuyền công khai*/
            myDouble = 5.67D;
            myNumber = (int)myDouble;
            Console.WriteLine("Ép kiểu công khai: " + myNumber + " : " + myDouble);

            //Ngoài ra còn có thể sử dụng method của Convert để ép kiểu
            myDouble = 5.67D;
            Console.WriteLine("Sử dụng method của Convert: " + Convert.ToInt32(myDouble));

        }
    }
}
