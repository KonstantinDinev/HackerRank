using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms
{
    class DivisibleSumPairs
    {
        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            // Complete this function
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    if (i == j) continue;
                    else if ((ar[i] + ar[j]) % k == 0 && i < j)
                    {
                        cnt++;
                        Console.Write("{0} + {1} = {2}\n", ar[i], ar[j], ar[i] + ar[j]);
                    }
                }
            }
            return cnt;
        }

        public static void Init()
        {
            string[] tokens_n = "6 3".Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = "1 3 2 6 1 2".Split(' ');
            //int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int[] ar = ar_temp.Select(s => Int32.Parse(s)).ToArray();
            int result = divisibleSumPairs(n, k, ar);
            Console.WriteLine(result);
        }
    }
}
