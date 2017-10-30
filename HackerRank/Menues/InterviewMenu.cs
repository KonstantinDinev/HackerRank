using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Menues
{
    class InterviewMenu
    {
        static public void Menu()
        {
            string text = @"
    Cracking the Coding Interview

        1. Array Left Rotation
        2. Balanced Brackets
        3. Davis Staircase - Recursion
        4. 
        5. 
        6. 
        7. 
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
                        MainMenu.Menu();
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("");
                        CodingInterview.ArrayLeftRotation.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("");
                        CodingInterview.BalancedBrackets.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("");
                        CodingInterview.DavisStaircase.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("");

                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("");

                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("");

                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("");

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
