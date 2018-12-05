using System;

namespace Uppg_8_1
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal persons = AskForPersons();
            ReturnHowMany(persons);
        }


        static decimal AskForPersons()
        {

            Console.Write("The chocolatebar contains 24 pieces. \n" +
                "How many want to share? ");
            try
            {
                decimal persons = decimal.Parse((Console.ReadLine()));
                Console.WriteLine();
                return persons;
            }


            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter a number!");
                Console.ResetColor();
                return AskForPersons();
            }

        }

        private static void ReturnHowMany(decimal persons)
        {
            try
            {
                decimal each = (24 / persons);

                Console.WriteLine($"Everyone gets {each} pieces. \n");
            }
            catch (DivideByZeroException)//"ex" för att hitta vilket fel det är 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zero People cant divide a chocolate!");
                Console.ResetColor();
            }

        }

    }
}
