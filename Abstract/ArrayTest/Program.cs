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

            string[][] arr = new string[3][] { a, b, d };
            //Bai1
            string[][] c = GhepPhanTu(a, b);
            for(int i = 0; i< c.Length; i++)
            {
                for(int j = 0; j< b.Length; j++)
                {
                    Console.Write(c[i][j]);
                }
            }
            Console.WriteLine();
            //Bai2
            string[][] e = GhepPhanTu(c, d);
            for (int i = 0; i < e.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(e[i][j]);
                }
            }
            Console.WriteLine();
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
            int resultIndex = 0;
            string[][] result = new string[c.Length * d.Length][];
            string[] tam = new string[2];
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (j > 0)
                    {
                        tam[1] = c[i][j];
                        for (int k = 0; k < 2; k++)
                        {
                            result[resultIndex] = new string[] { tam[0], tam[1], d[k] };
                            resultIndex++;
                        }
                        tam = new string[2];
                    }
                    else
                    {
                        tam[0] = c[i][j];
                    }
                }
            }
            return result;
        }
        /*public static string[][] GhepPhanTuNangCao(params string[][] args)
        {
            // đầu vào là 1 mảng, trong mỗi phần tử là 1 mảng 1 chiều
            //vd: args=[ ["1","2"], ["a","b"], ["x","y","z"] ];
            //return [[ "1", "a","x" ], [ "1", "a","y" ] , [ "1", "a","z" ] , ... , , [ "2", "b","z" ]]

            for (int i = 0; i < args.Length; i++)
            {
                for (int j = 0; j < args.Length; j++)
                {
                    if(args[i][j] != 0)
                    {

                    }
                }
            }
            string[][] result = new string[][];
        }*/
    }
}
