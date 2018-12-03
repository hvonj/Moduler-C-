using System;

namespace Module3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Times to repeat: ");
            int nummer = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;


                for (int i = 0; i < nummer; i++)
            {
                Console.WriteLine($"Your name is {myName}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
