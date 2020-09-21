using System;
using System.Collections.Generic;
using System.Text;

namespace StringTest
{
    public class TestVersion
    {
        public int NumberOfVersion { get; set; }

        public override string ToString()
        {
            return ChangeToText();
        }

        public string ChangeToText()
        {
            // do your code here
            // if NumberOfVersion < 1000000 return text (eg: NumberOfVersion =1 return "Mot", NumberOfVersion=99999 return "Chin muoi chin nghin chin tram chin chin" ...
            //else return NumberOfVersion.ToString()
            if (NumberOfVersion > 0 && NumberOfVersion <= 9)
                return TextNumber(NumberOfVersion);
            else if (NumberOfVersion > 9 && NumberOfVersion <= 99)
                return HangChuc(NumberOfVersion);
            else if (NumberOfVersion > 99 && NumberOfVersion <= 999)
                return HangTram(NumberOfVersion);
            else if (NumberOfVersion > 999 && NumberOfVersion <= 9999)
                return HangNghin(NumberOfVersion);
            else if (NumberOfVersion > 9999 && NumberOfVersion <= 99999)
                return HangChucNghin(NumberOfVersion);
            else if (NumberOfVersion > 99999 && NumberOfVersion <= 999999)
                return HangTramNghin(NumberOfVersion);
            else
                return NumberOfVersion.ToString();
        }
        public string HangChuc(int number)
        {
            int hangChuc = number / 10;
            int hangDonVi = number % 10;
            if (hangChuc == 0 && hangDonVi > 0)
                return "Le " + TextNumber(hangDonVi);
            else if (hangChuc == 0 && hangDonVi == 0)
                return "";
            else if (hangChuc == 1)
                return (hangDonVi==0)? " Muoi " : " Muoi " + TextNumber(hangDonVi);
            else if (hangChuc > 1)
                return TextNumber(hangChuc) + " Muoi " + TextNumber(hangDonVi);
            else
                return TextNumber(hangChuc) + " " + TextNumber(hangDonVi);
        }
        public string HangTram(int number)
        {
            int hangTram = number / 100;
            return TextNumber(hangTram) + " Tram " + HangChuc(number % 100);
        }
        public string HangNghin(int number)
        {
            int hangNghin = number / 1000;
            return TextNumber(hangNghin) + " Nghin " + HangTram(number % 1000);
        }
        public string HangChucNghin(int number)
        {
            int hangChucNghin = number / 10000;
            if (hangChucNghin == 0)
                return " Le " + HangNghin(number % 10000);
            else if (hangChucNghin == 1)
                return " Muoi " + HangNghin(number % 10000);
            else
                return TextNumber(hangChucNghin) + " Muoi " + HangNghin(number % 10000);
        }
        public string HangTramNghin(int number)
        {
            int hangTramNghin = number / 100000;
            return TextNumber(hangTramNghin) + " Tram " + HangChucNghin(number % 100000);
        }
        public string TextNumber(int number)
        {
            string result = "";
            switch (number)
            {
                case 0:
                    result = "Khong";
                    break;
                case 1:
                    result = "Mot";
                    break;
                case 2:
                    result = "Hai";
                    break;
                case 3:
                    result = "Ba";
                    break;
                case 4:
                    result = "Bon";
                    break;
                case 5:
                    result = "Nam";
                    break;
                case 6:
                    result = "Sau";
                    break;
                case 7:
                    result = "Bay";
                    break;
                case 8:
                    result = "Tam";
                    break;
                case 9:
                    result = "Chin";
                    break;
            }
            return result;
        }
    }
}
