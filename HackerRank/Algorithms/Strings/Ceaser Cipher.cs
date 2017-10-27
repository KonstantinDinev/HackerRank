using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Algorithms
{
    class CeaserCipher
    {
        public static void Init()
        {
            //input:
            //11
            //middle - Outz
            // 2 -> Try with 52
            //int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sentence to encrypt: -> ");
            string s = Console.ReadLine();
            Console.Write("Cipher: -> ");
            int k = Convert.ToInt32(Console.ReadLine());

            char[] charArr = new char[s.Length];
            charArr = s.ToCharArray();
            //65-90, 97-122
            int[] ASCII = new int[charArr.Length];
            for (int i = 0; i < ASCII.Length; i++)
            {
                ASCII[i] = (int)charArr[i];
            }

            //Encrypting
            int temp = k;
            for (int i = 0; i < ASCII.Length; i++)
            {
                if (ASCII[i] >= 65 && ASCII[i] <= 90)
                {
                    if (ASCII[i] + k > 90)
                    {
                        temp = ASCII[i] + k - 90;
                        while (64 + temp > 90)
                        {
                            temp = (temp + 64) - 90;
                        }
                        ASCII[i] = 64 + temp;
                    }
                    else ASCII[i] = ASCII[i] + k;
                }
                else if (ASCII[i] >= 97 && ASCII[i] <= 122)
                {
                    if (ASCII[i] + k > 122)
                    {
                        temp = ASCII[i] + k - 122;
                        while (96 + temp > 122)
                        {
                            temp = (temp + 96) - 122;
                        }
                        ASCII[i] = 96 + temp;
                    }
                    else ASCII[i] = ASCII[i] + k;
                }
            }

            //Converting to Characters
            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = (char)ASCII[i];
            }

            foreach (char c in charArr) Console.Write(c);

            //Decrypting
            //int temp = k;
            for (int i = 0; i < ASCII.Length; i++)
            {
                if (ASCII[i] >= 65 && ASCII[i] <= 90)
                {
                    if (ASCII[i] - k < 65)
                    {
                        temp = 64 - (ASCII[i] - k);
                        while (90 - temp <= 64)
                        {
                            temp = (64 + temp) - 90;
                        }
                        ASCII[i] = 90 - temp;
                    }
                    else ASCII[i] = ASCII[i] - k;
                }
                else if (ASCII[i] >= 97 && ASCII[i] <= 122)
                {
                    if (ASCII[i] - k < 97)
                    {
                        temp = 96 - (ASCII[i] - k);
                        while (122 - temp <= 96)
                        {
                            temp = (96 + temp) - 122;
                        }
                        ASCII[i] = 122 - temp;
                    }
                    else ASCII[i] = ASCII[i] - k;
                }
            }

            //Converting to Characters
            for (int i = 0; i < charArr.Length; i++)
            {
                charArr[i] = (char)ASCII[i];
            }

            Console.WriteLine("");
            foreach (char c in charArr) Console.Write(c);

        }
    }
}