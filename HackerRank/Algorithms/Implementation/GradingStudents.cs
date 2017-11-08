using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.Algorithms
{
    class GradingStudents
    {
        static int[] solve(int[] grades)
        {
            int temp = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > 37)
                {
                    if ((grades[i] % 10) < 5)
                    {
                        temp = 5 - (grades[i] % 10);
                        if (temp < 3) grades[i] = ((grades[i] / 10) * 10) + 5;
                    }
                    else if (grades[i] % 10 > 5)
                    {
                        temp = 10 - (grades[i] % 10);
                        if (temp < 3) grades[i] = ((grades[i] / 10) * 10) + 10;
                    }
                }
            }
            return grades;
        }

        static public void Init()
        {
            int n = 4;  //Convert.ToInt32(Console.ReadLine());
            string[] input = "73 67 38 33".Split(' ');
            int[] grades = new int[n];
            grades = input.Select(s => Int32.Parse(s)).ToArray();
            //for (int grades_i = 0; grades_i < n; grades_i++)
            //{
            //    grades[grades_i] = Convert.ToInt32(Console.ReadLine());
            //}
            int[] result = solve(grades);
            Console.WriteLine(String.Join("\n\n", result));


        }
    }
}
