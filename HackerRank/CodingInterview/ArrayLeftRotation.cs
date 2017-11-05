using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.CodingInterview
{
    class ArrayLeftRotation
    {
        static public void Init()
        {
            //input
            // 5 4
            // 1 2 3 4 5
            string[] tokens_n = "5 4".Split(' ');//Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int d = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = "1 2 3 4 5".Split(' ');//Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] a = a_temp.Select(s => Int32.Parse(s)).ToArray();

            int[] b = new int[n];
            for (int i = 0; i < n; i++)
                b[(i + n - d) % n] = a[i];

            for (int i = 0; i < n; i++)
                Console.Write(b[i] + " ");

            //Failing last two tests due to timeout
            //int i;
            //for(i = 0; i < d; i++)
            //{
            //    RotateByOne(a, n);
            //}

            //foreach(int num in a) Console.Write(num + " ");
        }

        //static void RotateByOne(int[] arr, int n)
        //{
        //    int temp = 0, i;

        //    for (i = 0; i < n - 1; i++)
        //    {
        //        temp = arr[i];
        //        arr[i] = arr[i + 1];
        //        arr[i + 1] = temp;
        //    }
        //}
    }
}
