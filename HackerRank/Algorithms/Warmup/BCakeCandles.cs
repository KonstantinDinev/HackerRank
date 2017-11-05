using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms
{
    class BCakeCandles
    {
        static public void Init()
        {
            int n = 4; // Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = "3 1 2 3".Split(' ');
            int[] ar = ar_temp.Select(s => Int32.Parse(s)).ToArray();
            //int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }

        static int birthdayCakeCandles(int n, int[] ar)
        {
            // Complete this function
            int maxEl = 0, cntAppearances = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] >= maxEl)
                {
                    maxEl = ar[i];
                }
            }

            foreach (int numb in ar) if (maxEl == numb) cntAppearances++;

            return cntAppearances;
        }
    }
}
