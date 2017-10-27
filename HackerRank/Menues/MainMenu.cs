using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class MainMenu
    {
        static public void Menu()
        {
            string text = @"
    You can select your choice by pressing a number from 0 to 9

        1. Algorithms
        2. Coding Interview
        3. 
        4. 
        5. 
        6. 
        7. 
        8. 
        9. Bonus Track

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
                        Console.WriteLine(""); Console.Clear();
                        Menues.Algorithm.Menu();
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(""); Console.Clear();
                        Menues.InterviewMenu.Menu();
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(""); Console.Clear();
                        
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(""); Console.Clear();

                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine(""); Console.Clear();

                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine(""); Console.Clear();

                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine(""); Console.Clear();

                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine(""); Console.Clear();

                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine(""); Console.Clear();

                        Console.ReadKey();
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
