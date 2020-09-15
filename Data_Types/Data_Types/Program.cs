using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //kiểu dữ liệu là kiểu mà dữ liệu được quy định gán vào biến
            //nếu gán dữ liệu sai sẽ bị lỗi fix bằng cách ép kiểu
            
            //dữ liệu kiểu số nguyên gồm có int và long
            int myNumberInt = 15;
            long myNumberLong = 30;
            
            //dữ liệu kiểu số thập phân
            float myFloat = 5.6F;
            double myDouble = 9.7D;

            //dữ liệu kiểu boolean
            bool myBoolean = true;

            //kiểu dữ liệu đơn
            char myChar = 'V';

            //kiểu dữ liệu chuỗi
            string myString = "Vuong";

            Console.WriteLine(myNumberInt + "\n" + myNumberLong + "\n" + myFloat + "\n"
                + myDouble + "\n" + myBoolean + "\n" + myChar + "\n" + myString);
        }
    }
}
