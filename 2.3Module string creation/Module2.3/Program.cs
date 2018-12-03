using System;
using System.Collections.Generic;

namespace Module2._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many fruits do you want to add?");
            Console.ReadLine();

            List<string> fruits = new List<string>();
            Console.Write("Enter fruit 1: ");
            string fruits1 = Console.ReadLine();

            Console.Write("Enter fruit 2: ");
            string fruits2 = Console.ReadLine();

            Console.Write("Enter fruit 3: ");
            string fruits3 = Console.ReadLine();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"You entered three fruits: {fruits1.ToUpper()}, {fruits2}, {fruits3}");
            Console.WriteLine($"You entered three fruits: {fruits1}, {fruits2}, {fruits3}");
            Console.WriteLine($"You entered three fruits: {fruits1}, {fruits2}, {fruits3}");

        }
    }
}
