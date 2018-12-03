using System;

namespace Module_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter names in a list (like Maria, Peter, Lisa): ");
            string names = Console.ReadLine();
            string[] namesList = names.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();

            foreach (string name in namesList)
            {
                if (name == "Zelda")
                {
                    break;
                }
                Console.WriteLine($"{name} Andersson");
            }

            // Split
            // foreach


           // while (!list.Contains("Zelda"))
           // {
           //     if (list.Contains("Zelda"))
           //     {
           //         list.Remove("Zelda");
           //         break;
           //     }

           //}
           // list.ForEach(i => Console.Write("{0} " + " Andersson \n", i));
        }
    }
}
