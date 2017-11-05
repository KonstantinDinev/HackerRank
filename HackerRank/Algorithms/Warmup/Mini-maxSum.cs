using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms
{
    class Mini_maxSum
    {
        public static void Init()
        {
            string[] arr_temp = "1 2 3 4 5".Split(' ');
            //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int[] arr = arr_temp.Select(s => Int32.Parse(s)).ToArray();
            //times will be also the length of the array

            Sums(arr, arr.Length);
        }

        static void Sums(int[] arr, int times)
        {
            long min = long.MaxValue, max = 0, cnt = 0, sum = 0;
            for (int n = 0; n <= times; n++)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (cnt == i) continue;
                    else if (cnt == arr.Length) break;
                    else
                    {
                        //Console.WriteLine("the index: " + i);
                        sum += arr[i];
                        //Console.WriteLine("sum is " + sum);
                    }
                }
                if (sum > max) max = sum;
                if (cnt == arr.Length) break;
                else if (sum < min) min = sum;

                cnt++; sum = 0;
                //Console.WriteLine("");
            }

            Console.Write("{0} {1}", min, max);
        }
    }
}
