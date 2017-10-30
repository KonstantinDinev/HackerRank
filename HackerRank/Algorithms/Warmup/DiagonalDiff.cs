using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    //Diagonal Difference
    class DiagonalDiff
    {
        public static void Init()
        {
            //Console.Write("n = ");
            int n = 10;//Int32.Parse(Console.ReadLine());
            int[,] a = new int[n,n];

            //input
            Random r = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i,j] = r.Next(0, 10);
                    Console.Write(a[i,j] + " ");
                }
                Console.WriteLine("");
            }
            //output
            int sumLR = 0, sumRL = 0;

            //Diagonal left to right
            for (int i = 0; i < n; i++)
            {
                sumLR += a[i,i];
            }
            //Diagonal right to left
            for (int i = 0, j = n - 1; i < n && j >= 0; i++, j--)
            {
                sumRL += a[i,j];
            }

            Console.Write(Math.Abs(sumLR - sumRL));
        }
    }
}
