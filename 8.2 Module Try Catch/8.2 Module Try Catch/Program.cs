using System;
using System.IO;

namespace Uppgift8_2v2
{
    class Program
    {
        static string path;

        static void Main(string[] args)
        {
            Console.Write("Enter a file: ");
            path = Console.ReadLine();

            try
            {
                File.CreateText(path);
                Console.WriteLine($"The file '{path}' is now created.");

            }
            catch (UnauthorizedAccessException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You are not authoterized to create that file 1.");
                Console.ResetColor();
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter something!");
                Console.ResetColor();
            }
            catch (System.IO.IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must enter a correct file.");
                Console.ResetColor();
            }

            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Something went wrong.");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }



        }
    }
}
