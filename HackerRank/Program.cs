using System;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my HackerRank App!\nI hope you find it useful!");
            Menu();
            Console.ReadKey();
        }




        static public void Menu()
        {
            string text = @"
    You can select your choice by pressing a number from 0 to 9

        1. Compare The Triplets
        2. Diagonal Difference
        3. Plus Minus

        0. Exit";

            Console.WriteLine(text);
            byte choice;
            Console.Write("\n\tChoice = ");
            bool result = byte.TryParse(Console.ReadLine(), out choice);
            if (!result) { Console.Clear(); Console.WriteLine("Incorrect choice!\nPlease enter your choice again!\n"); Menu(); }

            switch (choice)
            {
                case 0:
                    {
                        Environment.Exit(0);
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