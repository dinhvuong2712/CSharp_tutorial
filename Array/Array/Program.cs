using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mảng dùng để lưu trữ nhiều giá trị trong 1 biến duy nhất
            thay vì khai báo nhiều biến cho từng giá trị*/
            string[] arrayString = { "Dang", "Dinh", "Vuong" };

            //Truy cập 1 thành phần trong mảng thông qua vị trí index của thành phần trong mảng
            string myString = arrayString[1];
            Console.WriteLine(myString);

            //Thay đổi giá trị của 1 thành phần trong mảng
            arrayString[1] = "Van";
            Console.WriteLine(arrayString[1]);

            //For loop 1 mảng và độ dài mảng
            for(int i = 0; i < arrayString.Length; i++)
            {
                Console.WriteLine(arrayString[i]);
            }
            
            //Foreach dành riêng cho mảng
            foreach(string items in arrayString)
            {
                Console.WriteLine(items);
            }

            //Sort Array sắp xếp các thành phần (phần tử) trong mảng theo thứ tự bảng chữ cái hoặc theo thứ tự tăng dần trong mảng
            int[] arrayInt = { 1, 3, 2, 8, 4, 6, 5 };
            Array.Sort(arrayInt);
            for(int j = 0; j < 6; j++)
            {
                Console.WriteLine(arrayInt[j]);
            }

            //Một số phương thức trong System.Linq như Min() Max() Sum()
            foreach(int items in arrayInt)
            {
                Console.WriteLine(items);
            }

            //Các cách khởi tạo mảng
            string[] arrayString1 = new string[3];
            arrayString1[1] = "Dang";
            arrayString1[2] = "Dinh";
            arrayString1[3] = "Vuong";

            string[] arrayString2 = new string[3] { "Dang", "Dinh", "Vuong" };

            string[] arrayString3 = new string[] { "Dang", "Dinh", "Vuong" };

            string[] arrayString4 = { "Dang", "Dinh", "Vuong" };
        }
    }
}
