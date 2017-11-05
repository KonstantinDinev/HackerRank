using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Menues
{
    class Warmup
    {
        static public void Menu()
        {
            string text = @"
    Algorithms sub-menues

        1. Triplets
        2. Diagonal Difference
        3. Plus-Minus
        4. Staircase
        5. Mini-Max Sum
        6. Birthday Cake Candles
        7. Time Conversion
        8. 
        9. 

        0. Back";

            Console.WriteLine(text);
            byte choice;
            Console.Write("\n\tChoice = ");
            bool result = byte.TryParse(Console.ReadLine(), out choice);
            if (!result) { Console.Clear(); Console.WriteLine("Incorrect choice!\nPlease enter your choice again!\n"); Menu(); }

            switch (choice)
            {
                case 0:
                    {
                        Console.Clear();
                        Algorithm.Menu();
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("");
                        Algorithms.Triplets.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("");
                        Algorithms.DiagonalDiff.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("");
                        Algorithms.PlusMinus.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("");
                        Algorithms.Staircase.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("");
                        Algorithms.Mini_maxSum.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("");
                        Algorithms.BCakeCandles.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("");
                        Algorithms.TimeConversion.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("");

                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("");

                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("Incorrect choice!\nPlease enter your choice again!\n");
                        Menu();
                        break;
                    }
            }
        }
    }
}
