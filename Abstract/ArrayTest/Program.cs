using ArrayTest;
using StringTest;
using System;
using System.Collections;
using System.Collections.Generic;

namespace StringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "1", "2", "3" };
            string[] b = { "a", "b" };
            string[] d = { "x", "1" };

            string[][] arr = new string[][] { a, b, d };
            //Bai1
            string[][] c = GhepPhanTu(a, b);
            for(int i = 0; i< c.GetLength(0); i++)
            {
                for(int j = 0; j< 2; j++)
                {
                    Console.Write(c[i][j]);
                }
            }
            Console.WriteLine();
            
            //Bai2
            string[][] e = GhepPhanTu(c, d);
            for (int i = 0; i < e.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(e[i][j]);
                }
            }
            Console.WriteLine();

            //Bai3
            string[][] arrays = GhepPhanTuNangCao(arr);
            for (int i = 0; i < arrays.GetLength(0); i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arrays[i][j]);
                }
            }
        }
        public static string[][] GhepPhanTu(string[] a, string[] b)
        {
            // đầu vào là 2 mảng 1 chiều
            //vd:
            //a = ["a1","a2"]
            //b = ["b1","b2"]
            //return [ ["a1","b1"],["a1","b2"], ["a2","b1"], ["a2","b2"] ]
            int resultLenght = a.Length * b.Length;
            string[][] result = new string[resultLenght][];
            int resultIndex = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[resultIndex] = new string[] { a[i], b[j] };
                    resultIndex++;
                }
            }
            return result;
        }
        public static string[][] GhepPhanTu(string[][] c, string[] d)
        {
            string[][] result = new string[c.Length * d.Length][];
            int resultIndex = 0;
            for(int i=0; i<c.GetLength(0); i++)
            {
                for(int j=0; j<2; j++)
                {
                    if (j == 1)
                    {
                        for (int k = 0; k < d.Length; k++)
                        {
                            result[resultIndex] = new string[]{c[i][j-1],c[i][j],d[k]};
                            resultIndex++;
                        }
                    }
                }
            }
            return result;
        }
        public static string[][] GhepPhanTuNangCao(params string[][] args)
        {
            // đầu vào là 1 mảng, trong mỗi phần tử là 1 mảng 1 chiều
            //vd: args=[ ["1","2"], ["a","b"], ["x","y","z"] ];
            //return [[ "1", "a","x" ], [ "1", "a","y" ] , [ "1", "a","z" ] , ... , , [ "2", "b","z" ]]
            int lenght = 0;
            for(int i=0; i<args.GetLength(0); i++)
            {
                string[] itemLenght = args[i];
                lenght *= itemLenght.Length;
            }
            string[][] result = new string[lenght][];


            for (int i=0; i<args.GetLength(0); i++)
            {
                string[] firstItem = args[i];
                if (i > 0)
                {
                    result = GhepPhanTu(result, firstItem);
                }
                else
                {
                    string[] lastItem = args[i + 1];
                    result = GhepPhanTu(firstItem,lastItem);
                }
                i++;
            }
            return result;
        }
    }
}
