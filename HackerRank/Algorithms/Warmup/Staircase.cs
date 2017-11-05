using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class Staircase
    {
        public static void Init()
        {
            int n = 15; // Convert.ToInt32(Console.ReadLine());
            char[,] arr = new char[n, n];
            //input marking the diagonal  
            for (int i = 0, j = arr.GetLength(1) - 1; i < arr.GetLength(0) && j >= 0; i++, j--)
            {
                arr[i, j] = '#';
            }

            //algorithm
            bool flag = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == '#')
                    {
                        flag = true;
                    }
                    arr[i, j] = ' '; //if you comment this line it becomes a pyramid ^^
                    if (flag)
                    {
                        arr[i, j] = '#';
                    }
                }
                flag = false;
            }

            //output
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + ""); //remove the space here and comment as pyramid
                }
                Console.WriteLine("");
            }
        }
    }
}
