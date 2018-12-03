using System;

namespace Module3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv in din ålder: ");
            string age = Console.ReadLine();
            int number = Convert.ToInt32(age);

            Console.Write("Skriv in ditt kön: ");
            string gender = Console.ReadLine();


            Console.ForegroundColor = ConsoleColor.Red;

            //string mystring = somethingThatIsTrueOfFalse ? "aaaa" : "bbbb"
            // 

            if (number <= 50 && gender == "Man")
            {
                Console.WriteLine("\nDu är en ung och frisk man!\n");
            }
            else if (number >= 50 && gender == "Man")
            {
                Console.WriteLine("\nDu är en gammal men frisk gubbe!\n");
            }
            
            else if (number <=50 && gender == "Kvinna")
            {
                Console.WriteLine("\nDu är en ung och frisk kvinna!\n");
            }
            else
            {
                Console.WriteLine("\nDu är en gammal men frisk kvinna!\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }   
    }       
}
