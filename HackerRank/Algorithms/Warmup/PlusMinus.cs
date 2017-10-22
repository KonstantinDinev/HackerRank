using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HackerRank.Algorithms
{
    class PlusMinus
    {

        public static void Init()
        {
            int n = 6;
            string input = "-4 3 -9 0 4 1";
            Console.WriteLine("Input: 6\n{0}\n", input);
            string[] arr_temp = input.Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] arr = arr_temp.Select(s => Int32.Parse(s)).ToArray();

            float posNum = 0, negNum = 0, zero = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) { posNum++; }
                else if (arr[i] < 0) { negNum++; }
                else zero++;
            }
            float res = posNum / (float)n;
            Console.WriteLine("{0:0.0000000}", res);
            res = negNum / (float)n;
            Console.WriteLine(res);
            res = zero / (float)n;
            Console.WriteLine(res);
        }
    }
}
