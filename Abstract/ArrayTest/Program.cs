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

            string[][] c = GhepPhanTu(a, b);
            foreach(var items in a)
            {
                Console.WriteLine(items.ToString());
            }

            //Bai1
            for(int i = 0; i< c.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(c[i][j].ToString());
                }
            }
            Console.WriteLine();
            //Bai2
            string[][] e = GhepPhanTu(c, d);
            for(int i = 0; i< e.Length; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    Console.Write(e[i][j].ToString()) ;
                }
            }
            Console.WriteLine();
            //Bai3
            string[][] advancedArr = GhepPhanTuNangCao(a,b,d);
            for(int i=0; i<advancedArr.Length; i++)
            {
                for(int j = 0; j < a.Length; j++)
                {
                    Console.Write(advancedArr[i][j].ToString());
                }
            }
            
        }

        static string[][] GhepPhanTu(string[] a, string[] b)
        {
            int index = -1;
            string[][] c = new string[a.Length*b.Length][];
            for (int j = 0; j < a.Length; j++)
            {
                for (int k = 0; k < b.Length; k++)
                {
                    index++;
                    c[index] = new string[] { a[j], b[k] };
                }
            }
            return c;
        }
        
        static string[][] GhepPhanTu(string[][]c, string[] d)
        {
            int index = -1;
            string[][] e = new string[c.Length * d.Length][];
            for(int i = 0; i < c.Length; i++)
            {
                for(int j = 0; j < d.Length; j++)
                {
                    int k = 0;
                    index++;
                    e[index] = new string[] { c[i][k], c[i][k+1], d[j]};
                }
            }

            return e;
        }
        static string[][] GhepPhanTuNangCao(string[]a, string[]b, string[]d)
        {
            int lenghtArr = a.Length * b.Length * d.Length;
            int indexArr = -1;
            string[][] arr = new string[lenghtArr][];
            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    for(int k = 0; k < d.Length; k++)
                    {
                        indexArr++;
                        string[] arrItems = new string[] { a[i], b[j], d[k] };
                        arr[indexArr] = arrItems;
                    }
                }
            }
            return arr;
        }
    }
}
