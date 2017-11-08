using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class HackerRankString
    {
        static string IsHacker(string txt)
        {
            Queue<char> que = new Queue<char>("hackerrank".ToCharArray());
            foreach (char c in txt)
            {
                if (c == que.Peek())
                    que.Dequeue();

                if (que.Count == 0)
                    return "YES";
            }
            return "NO";
        }

        static public void Init()
        {
            int q = 2;//Convert.ToInt32(Console.ReadLine());
            string[] s = new string[q];
            s[0] = "hereiamstackerrank";
            s[1] = "hackerworld";

            for (int a0 = 0; a0 < q; a0++)
            {
                //s = Console.ReadLine();
                Console.WriteLine(IsHacker(s[a0]));
            }
        }
    }
}
