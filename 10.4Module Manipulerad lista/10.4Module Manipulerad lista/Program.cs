using System;
using System.Collections.Generic;

namespace _10._4Module_Manipulerad_lista
{
    class Program
    {
        private static List<string> ListOfNames = new List<string>();
        static void Main(string[] args)
        {
            ListOfNames = AskForNames();
            DisplayList(ListOfNames);
        }

        static List<string> AskForNames()
        {
            string x;
            do
            {
                Console.Write("Enter a name: ");
                x = Console.ReadLine();

                if (x.ToLower() != ("quit"))
                {
                    ListOfNames.Add(x);
                }
            }
            while (x.ToLower() != "quit");
            return ListOfNames;
        }

        private static void DisplayList(List<string> listOfNames)
        {
            //listOfNames.Sort();
            Console.WriteLine();
            if (listOfNames.Count >= 4)
            {
                ListOfNames.RemoveAt(0);
                ListOfNames.RemoveAt(listOfNames.Count - 1);

            }
            foreach (var item in listOfNames)
            {
                Console.WriteLine($"Name: {item}");
            }
        }

    } 

}
