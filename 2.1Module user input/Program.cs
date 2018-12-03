using System;
using System.Collections.Generic;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            Console.Write("What is your name? ");
            string myName = Console.ReadLine();

 
            Console.Write("How old are you? ");
            int myAge = int.Parse(Console.ReadLine());

            Console.Write("What is your favorite letter? ");
            string myLetter = Console.ReadLine();
            char inputCharacter = Convert.ToChar(myLetter);


            Console.WriteLine();
            Console.WriteLine("Thank you!\n");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Your name is: " + myName);
            Console.WriteLine($"You have {65 - myAge} years until retirement ");


            if (Char.IsNumber(inputCharacter))
            {
                Console.WriteLine("You like numbers");
            }
            else
            {
                Console.WriteLine("You don't like numbers");
            }

            Console.ResetColor();

        }
    
    }
}
