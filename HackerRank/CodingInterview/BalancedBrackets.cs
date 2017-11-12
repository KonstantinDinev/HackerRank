using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HackerRank.CodingInterview
{
    class BalancedBrackets
    {
        static private void TestCase()
        {
            using (var stream = new FileStream("CodingInterview\\tests\\BalancedBrackets\\bbTEST.txt", FileMode.Open))
            using (var expectedResults = File.OpenText("CodingInterview\\tests\\BalancedBrackets\\output.txt"))
            using (StreamReader sr = new StreamReader(stream))
            {
                int n = Int32.Parse(sr.ReadLine());
                string[] exp = new string[n];
                string[] testOutput = new string[n];

                for (int i = 0; i < n; i++)
                {
                    exp[i] = sr.ReadLine();
                    testOutput[i] = expectedResults.ReadLine();
                    //Console.WriteLine(Balance(exp[i]));

                    if(Balance(exp[i]).Equals(testOutput[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\tOK"); Console.ResetColor();
                        Console.WriteLine("\tTEST {0}: {1} == {2} \n", i, Balance(exp[i]), testOutput[i]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("INCORRECT"); Console.ResetColor();
                        Console.WriteLine("\tTEST {0}: {1} == {2} \n", i, Balance(exp[i]), testOutput[i]);
                    }
                }
            }
            Console.ReadLine();
        }
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

            Console.Write("\nWould you like to run a test case? (y/n) : ");
            if (Console.ReadLine() == "y") TestCase();
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
