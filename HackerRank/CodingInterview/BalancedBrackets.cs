using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.CodingInterview
{
    class BalancedBrackets
    {
        static public void Init()
        {
            Console.WriteLine(@"
        3
        {[()]}
        {[(])}
        {{[[(())]]}}"
);

            int t = 3;//Convert.ToInt32(Console.ReadLine());
            string[] expression = { "{[()]}", "{[(])}", "{{[[(())]]}}" };
            for (int a0 = 0; a0 < t; a0++)
            {
                //string expression = Console.ReadLine();
                Console.WriteLine(Balance(expression[a0]));
            }
        }

        static string Balance(string expr)
        {
            if (expr.Length % 2 == 0)
            {
                Stack<char> st = new Stack<char>();
                char peek;

                for (int i = 0; i < expr.Length; i++)
                {
                    switch (expr[i])
                    {
                        case '{':
                            {
                                //Console.Write('{');
                                st.Push('{');
                                break;
                            }
                        case '[':
                            {
                                //Console.Write('[');
                                st.Push('[');
                                break;
                            }
                        case '(':
                            {
                                //Console.Write('(');
                                st.Push('(');
                                break;
                            }
                        case '}':
                            {
                                if (st.Count == 0) return "NO";
                                //Console.Write('}');
                                peek = st.Peek();
                                if (peek != '{')
                                {
                                    for (int j = st.Count; j > 0; j--)
                                    {
                                        if (expr[j] == '{')
                                        {
                                            st.Pop();
                                            break;
                                        }
                                        else if (expr[j] == '(' || expr[j] == '[')
                                        {
                                            //Console.Write("NO");
                                            return "NO";
                                        }
                                    }
                                }
                                else if (peek == '{') st.Pop();
                                break;
                            }
                        case ']':
                            {
                                if (st.Count == 0) return "NO";
                                //Console.Write(']');
                                peek = st.Peek();
                                if (peek != '[')
                                {
                                    for (int j = st.Count; j > 0; j--)
                                    {
                                        if (expr[j] == '[')
                                        {
                                            st.Pop();
                                            break;
                                        }
                                        else if (expr[j] == '(' || expr[j] == '{')
                                        {
                                            //Console.Write("NO");
                                            return "NO";
                                        }
                                    }
                                }
                                else if (peek == '[') st.Pop();
                                break;
                            }
                        case ')':
                            {
                                if (st.Count == 0) return "NO";
                                //Console.Write(')');
                                peek = st.Peek();
                                if (peek != '(')
                                {
                                    for (int j = st.Count; j > 0; j--)
                                    {
                                        if (expr[j] == '(')
                                        {
                                            st.Pop();
                                            break;
                                        }
                                        else if (expr[j] == '{' || expr[j] == '[')
                                        {
                                            //Console.Write("NO");
                                            return "NO";
                                        }
                                    }
                                }
                                else if (peek == '(') st.Pop();
                                break;
                            }
                        default:
                            {
                                //Console.Write("Error");
                                break;
                            }
                    }
                }
                if (st.Count == 0) return "YES";
                else return "NO";
            }
            else
            {
                return "NO";
            }

        }
    }
}
