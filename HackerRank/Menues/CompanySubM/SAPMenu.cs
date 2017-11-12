using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Menues
{
    class SAPMenu
    {
        static public void Menu()
        {
            string text = @"
    SAP Bulgaria

        1. The most frequent occurrences of an item in a data structure
           (Hashtable or Dictionary)

        2. OOP Animal Shelter


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
                        CompaniesMenu.Menu();
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("");
                        Companies.SAP_Bulgaria.CommonOccurrences.Init();
                        Console.ReadKey(); Console.Clear();
                        Menu();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("");
                        Companies.SAP_Bulgaria.AnimalShelter<Companies.SAP_Bulgaria.Dog>.Init();
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
