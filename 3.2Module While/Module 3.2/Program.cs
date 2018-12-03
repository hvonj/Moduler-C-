using System;

namespace Module_3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Times to repeat: ");
            string myNumber = Console.ReadLine();
            int nummer = Convert.ToInt32(myNumber);

            Console.ForegroundColor = ConsoleColor.Green;

            int i = 0;
            while(nummer > i)
            {
            Console.WriteLine($"Your name is {myName}");
            nummer--;
            }

            //int i = 1;
            //while (true)
            //{
            //    Console.WriteLine($"Your name is {myName}", i);

            //   i++;

            //   if (i > nummer)
            //       break;

            //}

            Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }

