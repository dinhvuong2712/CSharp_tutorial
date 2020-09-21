using System;
using System.Linq;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Bai 1
            Version ver1 = new Version();
            ver1.NumberOfVersion = 1;
            string currentVer1 = ver1.ToString();
            Console.WriteLine(currentVer1);


            //Bai 2
            Version ver2 = new Version();
            Version ver3 = new Version();
            ver2.NumberOfVersion = 2;
            ver3.NumberOfVersion = 3;

            Version[] arrVersion = new Version[] { ver1, ver2, ver3 };
            for (int i = 0; i < arrVersion.Length; i++)
            {
                if (i == arrVersion.Length - 1)
                    Console.Write(arrVersion[i].NumberOfVersion);
                else
                    Console.Write(arrVersion[i].NumberOfVersion + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(ThayDoiVersion(arrVersion));


            //Bai 3
            Version ver4 = new Version();
            ver4.NumberOfVersion = 1000;
            arrVersion = new Version[] { ver1, ver2, ver3, ver4 };
            Console.WriteLine(ThayDoiVersion(arrVersion));*/


            //TestVersion

            foreach (var i in Enumerable.Range(0, 1500))
            {
                var v = new TestVersion { NumberOfVersion = i };
                Console.WriteLine($"-----: {i} in VN string: {v}");
                Console.WriteLine();
            }
        }

        /*static string ThayDoiVersion(Version[] arrayVersion)
        {
            string arrayResult = "";
            for (int i = 0; i < arrayVersion.Length; i++)
            {
                int number = arrayVersion[i].NumberOfVersion;
                string numberString = arrayVersion[i].NumberOfVersion.ToString();
                int lenghtNumber = numberString.Length;
                string kyTuPhay = ", ";
                if (i == arrayVersion.Length - 1)
                {
                    kyTuPhay = "";
                }
                switch (lenghtNumber)
                {
                    case 1:
                        arrayResult += ToString(number) + kyTuPhay;
                        break;
                    case 2:
                        arrayResult += HangChuc(number) + kyTuPhay;
                        break;
                    case 3:
                        arrayResult += HangTram(number) + kyTuPhay;
                        break;
                    case 4:
                        arrayResult += HangNghin(number) + kyTuPhay;
                        break;
                    default:
                        arrayResult += "Null ,";
                        break;
                }
            }
            return arrayResult;
        }
        static string HangChuc(int number)
        {
            int hangChuc = number / 10;
            int hangDonVi = hangChuc % 10;
            if (hangChuc > 1)
            {
                return ToString(hangChuc) + " Muoi " + ToString(hangDonVi);
            }
            else if (hangChuc == 0)
            {
                return " Le " + ToString(hangDonVi);
            }
            else
            {
                return ToString(hangChuc) + ToString(hangDonVi);
            }
        }

        static string HangTram(int number)
        {
            int hangTram = number / 100;
            int hangChuc = number % 100;
            return ToString(hangTram) + HangChuc(hangChuc);
        }
        static string HangNghin(int number)
        {
            int hangNghin = number / 1000;
            int hangTram = number % 1000;
            int hangChuc = number % 100;
            if (hangTram > 0 && hangChuc > 0)
            {
                return ToString(hangNghin) + " Nghin " + HangTram(hangTram) + HangChuc(hangChuc);
            }
            else
            {
                return ToString(hangNghin) + " Nghin ";
            }
        }
        static string ToString(int changeNumber)
        {
            string result = "";
            switch (changeNumber)
            {
                case 1:
                    result += "Mot";
                    break;
                case 2:
                    result += "Hai";
                    break;
                case 3:
                    result += "Ba";
                    break;
                case 4:
                    result += "Bon";
                    break;
                    //có thể cho thêm
            }
            return result;
        }*/
    }
}
