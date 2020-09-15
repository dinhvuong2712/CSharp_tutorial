using System;

namespace Constructor
{
    class Car
    {
        //Hàm khởi tạo khởi tạo dữ liệu cho các trường dữ liệu của class
        //trong trường hợp ko có dữ liệu truyền vào hàm khởi tạo sẽ nhập giá trị cho các trường
        public string model;
        public string color;

        public Car()
        {
            model = "Mustang";
            color = "Black";
        }
        static void Main()
        {
            Car car = new Car();
            Console.WriteLine(car.model + " " + car.color);
        }
    }
}
