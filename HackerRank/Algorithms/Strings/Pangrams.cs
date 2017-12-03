using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class Pangrams
    {
        public static string IsPangram(string s)
        {
            s = s.ToLower().Replace(" ", "");
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
                alphabet[i] = (char)(i + 97);

            Stack<char> st = new Stack<char>();
            bool flag = false;

            for (int i = 0; i < alphabet.Length; i++)
            {
                st.Push(alphabet[i]);
                for (int j = 0; j < s.Length; j++)
                {
                    if (st.Peek() == s[j])
                    {
                        //Console.Write("this is peek -> {0} \n", st.Peek());
                        st.Pop();
                        flag = true;
                        break;
                    }

                    if (s.Length - 1 == j && flag == false)
                    {
                        return "not pangram";
                    }
                }

                if (alphabet.Length - 1 == i && st.Count == 0)
                {
                    return "pangram";
                }
            }

            return "not pangram";
        }

        public static void Init()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string[] test = ("We promptly judged antique ivory buckles for the next prize; " +
                 "We promptly judged antique ivory buckles for the prize").Split(';');

            foreach (string s in test) Console.WriteLine(s + " -> " + IsPangram(s));
        }
    }
}
