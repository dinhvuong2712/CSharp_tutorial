using System;

namespace Method_Parametors
{
    class Program
    {
        static void Method(string name)
        {
            Console.WriteLine(name);
        }
        static void DefaultValue(string name = "No Name")
        {
            Console.WriteLine(name);
        }
        static string ReturnValues(string name)
        {
            return "Your name is " + name;
        }
        static void NamedArgument(string name1, string name2, string name3)
        {
            Console.WriteLine(name1 + name2 + name3);
        }
        static void NamedArgument2(string name1 = "Dang", string name2 = "Dinh", string name3 = "Vuong")
        {
            Console.WriteLine(name3);
        }
        static void Main(string[] args)
        {
            //Method Parametors là tham số của 1 phương thức được truyền qua và sử dụng trong method dưới dạng biến;
            //Tham truyền vào
            Method("Vuong");

            //Tham số mặc định
            DefaultValue("Dung");
            DefaultValue("Toan");
            DefaultValue();

            //Phương thức trả về giá trị
            Console.WriteLine(ReturnValues("Vuong"));

            /*Phương thức đối số (Named Argument) dùng để tiện cho việc có
            nhiều biến và mình chỉ muốn thao tác với những biến mình 
            gọi ra mà không cần phải theo thứ tự dưới dạng key: value*/
            NamedArgument(name3: "Vuong", name2: "Dinh", name1:"Dinh");
            NamedArgument2("name3");
        }
    }
}
