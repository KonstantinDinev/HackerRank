using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    //Compare The Triplets
    class Triplets
    {
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            int[] AB = { 0, 0 };
            int[] a = { a0, a1, a2 };
            int[] b = { b0, b1, b2 };

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > b[i]) AB[0]++;
                if (a[i] == b[i]) { }
                if (a[i] < b[i]) AB[1]++;
            }

            return AB;
        }

        public static void Init()
        {
            string a = "5 6 8", b = "5 6 10";
            Console.WriteLine("{0}\n{1}", a, b);

            string[] tokens_a0 = a.Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = b.Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
