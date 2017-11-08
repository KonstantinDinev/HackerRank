using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class MarsExploration
    {
        static public void Init()
        {
            string S = "SOSSPSSQSSOR";
            StringBuilder sb = new StringBuilder();
            string sos = "SOS";
            int count = 0;

            for (int i = 0; i < S.Length; i += 3)
            {
                sb.Clear();
                sb.Append(S.Substring(i, sos.Length));
                for (int j = 0; j < 3; j++)
                {
                    if (sb[j] != sos[j]) count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
