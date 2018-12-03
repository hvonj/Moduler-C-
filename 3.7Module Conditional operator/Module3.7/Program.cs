using System;

namespace Module3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());


            string mynumber = number < 20 ? "The number is lower than 20!" : "The number is higher than 20!";


            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(mynumber);

        }
    }
}
