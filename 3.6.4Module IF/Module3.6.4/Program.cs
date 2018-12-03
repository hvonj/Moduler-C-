using System;

namespace Module3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string str = Console.ReadLine();
            int number = Convert.ToInt32(str);

            //int number = int.Parse(Console.ReadLine());
            //ctrl . för att byta namn på en variabel i hela dok

            Console.ForegroundColor = ConsoleColor.Green;

            if (number < 20)
            {
                Console.WriteLine("\nThe number is lower than 20!\n");
                //message = "\nThe number is lower than 20!\n"
            }
            else if (number == 20)
            {
                Console.WriteLine("\nThe number is equal to 20!\n");
                //message = "\nThe number is equal to 20!\n"
            }
            else
            {
                Console.WriteLine("\nThe number is higher than 20!\n");
                //message = "\nThe number is higher than 20!\n"
            }

            Console.ForegroundColor = ConsoleColor.White;
        }   //Console.WriteLine(message);
    }
}
