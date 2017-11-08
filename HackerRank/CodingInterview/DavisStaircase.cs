using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.CodingInterview
{
    class DavisStaircase
    {
        static public void Init()
        {
            int s = 3;// Convert.ToInt32(Console.ReadLine());
            int[] n = {1, 3, 7};
            for (int a0 = 0; a0 < s; a0++)
            {
                //int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CountPaths(n[a0], 3));
            }
        }
        static int CountPaths(int s, int m)
        {
            return ModifiedFibonacci(s + 1, m);
        }

        static int ModifiedFibonacci(int n, int m)
        {
            int[] res = new int[n];
            res[0] = 1; res[1] = 1;
            for (int i = 2; i < n; i++)
            {
                res[i] = 0;
                for (int j = 1; j <= m && j <= i; j++)
                {
                    res[i] += res[i - j];
                }
            }
            return res[n - 1];
        }
    }
}
