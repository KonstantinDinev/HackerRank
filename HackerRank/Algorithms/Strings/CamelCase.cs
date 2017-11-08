using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class CamelCaseWords
    {
        public static int CamelCase(string s)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(s);

            List<string> words = new List<string>();

            for (int i = 0; i < sb.Length; i++)
            {
                if (Char.IsUpper(sb[i]))
                {
                    words.Add(sb.ToString(0, i));
                    Console.WriteLine(sb.ToString(0, i));
                    sb.Remove(0, i);
                    i = 0;
                }
                else if (i == sb.Length - 1)
                {
                    words.Add(sb.ToString(0, i + 1));
                    Console.WriteLine(sb.ToString(0, i+1));
                }
            }

            return words.Count;
        }

        public static void Init()
        {
            string s = "saveChangesInTheEditor";
            Console.WriteLine(CamelCase(s));
        }
    }
}
