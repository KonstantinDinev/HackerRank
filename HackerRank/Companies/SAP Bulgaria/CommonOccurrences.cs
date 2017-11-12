using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Companies.SAP_Bulgaria
{
    class CommonOccurrences
    {
        static void CommonOccurrence(int[] numbers)
        {
            var counts = new Dictionary<int, int>();
            int cnt = 0;

            foreach(int numb in numbers)
            {
                counts.TryGetValue(numb, out cnt);
                cnt++;

                //it replaces automatically the entry if exist
                //no need of "Contains"
                counts[numb] = cnt;
            }

            int mostFreqNumb = 0;
            int occur = 0;

            foreach(var pair in counts)
            {
                if(pair.Value > occur)
                {
                    occur = pair.Value;
                    mostFreqNumb = pair.Key;
                }
            }

            Console.WriteLine("Most frequently occurred item is: [{0}]!\nIt occurres [{1}] times!",
                mostFreqNumb, occur);
        }

        public static void Init()
        {
            int[] vector = { 0, 4, 7, 4, 5, 4, 5, 2, 1 };
            foreach (var i in vector) Console.Write(i + " ");
            Console.WriteLine("");

            CommonOccurrence(vector);
        }
    }
}
