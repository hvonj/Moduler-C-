using System;

namespace Module_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter names in a list: ");
            string names = Console.ReadLine();
            string[] nameList = names.Split(',');

            Console.ForegroundColor = ConsoleColor.Green;
            
            foreach (string name in nameList)
            {
                Console.WriteLine($"{name} Andersson");
            }


        }
            
    }
}
