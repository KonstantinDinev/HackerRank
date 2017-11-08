using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Expert
{
    class PermHackaton
    {
        static long solve(int[] x)
        {
            const int M = 1000000007;
            int n = x.Length;
            int i = 0, j = 0, min = 0;
            int[] p = new int[n + 1];
            //x.CopyTo(p, 1);
            int pLine = 0; long sum = 0;

            List<int> zeroPos = new List<int>();
            List<int> values = new List<int>();
            for (i = 0; i < x.Length; i++)
            {
                if (x[i] != 0)
                {
                    zeroPos.Add(i);
                    values.Add(x[i]);
                }
            }
            //foreach (int num in zeroPos) Console.Write("index - {0}", num); Console.WriteLine("");

            List<int> variations = new List<int>();
            List<int> lines = new List<int>();
            int[] copyArr = new int[n + 1];

            //array init
            for (int ini = 1; ini <= p.Length - 1; ini++)
                p[ini] = ini;

            //algorithm
            for (i = 1; i <= n; i++)
            {
                do
                {
                    Print(p); pLine++;

                    //If there is no missing value we return the line when it occurs
                    if (zeroPos.Count != x.Length)
                    {
                        //To print only what I look for
                        if (Contains(zeroPos, p, x, values))
                        {
                            //variations.Add(p);
                            Console.Write(String.Join(" ", p).Substring(1)); Console.WriteLine("");
                            lines.Add(pLine);
                        }
                    }
                    else if (zeroPos.Count == x.Length)
                    {
                        x.CopyTo(copyArr, 1);
                        Console.Write(String.Join(" ", p).Substring(1)); Console.WriteLine("");
                        bool isEqual = Enumerable.SequenceEqual(copyArr, p);
                        if (isEqual) return pLine;
                    }

                    //permutations starts from here
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

            foreach (int num in lines) sum = (sum + num) % M;
            return sum;
        }

        static bool Contains(List<int> positions, int[] perm, int[] searched, List<int> v)
        {

            for (int i = 0; i < positions.Count - 1; i++)
            {
                for (int j = 1; j < positions.Count; j++)
                {
                    if (perm[positions[i] + 1] == v[i] && perm[positions[j] + 1] == v[j])
                    {
                        //for(int k = 1; k < searched.Length+1; k++)
                        //{
                        //    //Console.Write(perm[k] + " ");
                        //}
                        return true;
                    }
                }//Console.WriteLine("");
            }

            return false;
        }

        static void Print(int[] m)
        {
            //for (int k = 1; k <= m.Length-1; k++) Console.Write(m[k] + " ");
            //Console.WriteLine("");
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
            //int n = 6;
            string[] a_temp = "0 2 3 0".Split(' ');
            int[] a = a_temp.Select(i => Int32.Parse(i)).ToArray();
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            long result = solve(a);
            Console.WriteLine(result);

        }
    }
}
