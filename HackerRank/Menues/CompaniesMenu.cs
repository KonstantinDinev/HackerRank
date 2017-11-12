using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Menues
{
    class CompaniesMenu
    {
        public static void Menu()
        {
            string text = @"
    List of Companies and their specific tasks for Junior positions

        1. SAP Bulgaria
        2. MusalaSoft
        3. Morgan Stanley Hungary
        4. Line Corporation Japan
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
                        Console.Clear();
                        SAPMenu.Menu();
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(""); Console.Clear();
                        MusalaMenu.Menu();
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(""); Console.Clear();
                        MorganMenu.Menu();
                        Console.ReadKey();
                        Menu();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(""); Console.Clear();
                        LineMenu.Menu();
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
