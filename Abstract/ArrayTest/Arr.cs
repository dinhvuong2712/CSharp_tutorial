using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayTest
{
    public class Arr
    {
        public string[][] GhepPhanTu(string[] a, string[] b)
        {
            // đầu vào là 2 mảng 1 chiều
            //vd:
            //a = ["a1","a2"]
            //b = ["b1","b2"]
            //return [ ["a1","b1"],["a1","b2"], ["a2","b1"], ["a2","b2"] ]
            int resultLenght = a.Length * b.Length;
            string[][] result = new string[resultLenght][];
            int resultIndex = 0;
            for(int i = 0; i<a.Length; i++)
            {
                for(int j = 0; j<b.Length; j++)
                {
                    result[resultIndex] = new string[] { a[i], b[j] };
                    resultIndex++;
                }
            }
            return result;
        }
        public string[][] GhepPhanTu(string[][]c , string[] d)
        {
            int resultIndex = 0;
            string[][] result = new string[c.Length*d.Length][];
            for (int i = 0; i< c.GetLength(0)-1; i++)
            {
                for (int j = 0; j< c.GetLength(1)-1; j++)
                {
                    for(int k = 0; k< d.Length; k++)
                    {
                        result[resultIndex] = new string[] { c[i][j], c[i][j], d[k] };
                        resultIndex++;
                    }
                }
            }
            return result;
        }
        /*public string[][] GhepPhanTuNangCao(params string[][] args)
        {
            // đầu vào là 1 mảng, trong mỗi phần tử là 1 mảng 1 chiều
            //vd: args=[ ["1","2"], ["a","b"], ["x","y","z"] ];
            //return [[ "1", "a","x" ], [ "1", "a","y" ] , [ "1", "a","z" ] , ... , , [ "2", "b","z" ]]
            for ()
            {

            }
        }*/

    }
}
