using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try catch dùng để bắt lỗi tránh bị chết văng khi chạy chương trình
            //Try catch:
            try
            {
                int x = 5;
                if (x > 10)
                {
                    Console.WriteLine("Success");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Final câu lệnh cho phép bạn thực thi mã bất kể đúng hay sai
                //Throw cho phép bạn tạo ra một lỗi tùy chỉnh
                throw new AccessViolationException();
            }
        }
    }
}
