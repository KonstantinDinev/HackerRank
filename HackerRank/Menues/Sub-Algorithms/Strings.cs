using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Menues
{
    class Strings
    {
        static public void Menu()
        {
            string text = @"
    Working with Strings:

        1. Ceaser Cipher
        2. Mars Exploration
        3. HackerRank in a String
        4. Camel Case
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
                        Algorithms.CeaserCipher.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("");
                        Algorithms.MarsExploration.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("");
                        Algorithms.HackerRankString.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("");
                        Algorithms.CamelCaseWords.Init();
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
