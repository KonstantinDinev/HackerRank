using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class SuperReducedString
    {
        static string super_reduced_string(string s)
        {

            char[] abc = s.ToCharArray();
            //Sorted alphabetical to be easier
            //but it breaks their logic...
            //Array.Sort(abc);

            StringBuilder sb = new StringBuilder();
            sb.Append(abc);

            int length = sb.Length;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < sb.Length - 1; j++)
                {
                    if (sb[j] == sb[j + 1])
                    {
                        sb.Remove(j, 2);
                        j--;
                    }
                }
            }
            if (sb.Length == 0) Console.WriteLine("Empty String");

            return sb.ToString();
        }

        public static void Init()
        {
            string[] testCases = { "aaabccddd", "aa", "baab" };
            string result;
            foreach(string test in testCases)
            {
                result = super_reduced_string(test);
                Console.WriteLine(result);
            }

        }
    }
}
