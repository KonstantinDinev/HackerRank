using System;
using System.Collections.Generic;
using System.Text;

// Permutations :
// Iterative algorithm for generating permutations
// in lexicographic order.
// (123456) to (654321)
namespace HackerRank.Expert
{
    class Permutation_Lex
    {
        static void Print(int[] m)
        {
            for (int k = 1; k <= m.Length - 1; k++) Console.Write(m[k] + " ");
            Console.WriteLine("");
        }

        static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void Init()
        {
            int n = 6;
            int i = 0, j = 0, min = 0;
            int[] p = new int[n + 1];

            //array init
            for (int ini = 1; ini <= p.Length - 1; ini++)
                p[ini] = ini;

            //algorithm
            for (i = 1; i <= n; i++)
            {
                do
                {
                    Print(p);
                    i = n - 1;
                    while (p[i] > p[i + 1] && i > 0) i--;

                    if (i == 0) break;
                    min = i + 1;

                    for (j = i + 2; j <= n; j++)
                    {
                        if (p[j] < p[min] && p[j] > p[i])
                        {
                            min = j;
                        }
                    }

                    swap(ref p[i], ref p[min]);

                    for (j = 1; j <= (n - i) / 2; j++)
                    {
                        swap(ref p[i + j], ref p[n - j + 1]);
                    }
                } while (true);
                if (i == 0) break;
            }

        }
    }
}
