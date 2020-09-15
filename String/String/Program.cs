using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            //String là chuỗi lưu dữ văn bản 1 biến string lưu dữ tất cả văn bản có trong dấu ngoặc kép
            string myString = "Dang Dinh Vuong";
            Console.WriteLine(myString);

            //String collection, nối chuỗi là cách dùng toán tử số học lên 2 biến chuỗi để nối lại thành 1 chuỗi mới
            string firstName = "Dang Dinh";
            string lastName = "Vuong";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            //String lenght Độ dài của 1 chuỗi được đo bằng phương thức Lenght để đo độ dài của chuỗi
            Console.WriteLine(fullName.Length);

            //Orther method, các phương thức khác của chuỗi như 
            //Viết hoa, viết thường tất cả các ký tự trong chuỗi 
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());

            //Access string truy cập chuỗi là lấy 1 phần tử trong chuỗi tại 1 vị trí (số chỉ mục) trong chuỗi
            Console.WriteLine(fullName[1]);

            //các phương thức khác như IndexOf() dùng để lấy ra vị trí (số chỉ mục) của phần tử đầu tiên tìm trong chuỗi
            //Và Substring() sử dụng để lấy ra 1 chuỗi mới từ vị trí của 1 phần tử trong chuỗi cha đến hết
            Console.WriteLine(fullName.IndexOf("V"));
            Console.WriteLine(fullName.Substring(9));

            //String Interpolation (nội suy chuỗi) là lấy giá trị của biến thành các trình dữ chỗ trong chuỗi mới
            string stringInter1 = "Big City";
            string stringInter2 = "Boy";
            Console.WriteLine($"This is {stringInter1}{stringInter2}");

            //Special Character, các ký tự đặc biệt sử dụng trong trường hợp trong văn bản có những ký tự mà C# không dịch đc
            string stringSpecial = "Dang Dinh \" Vuong \" ";
            Console.WriteLine(stringSpecial);

        }
    }
}
