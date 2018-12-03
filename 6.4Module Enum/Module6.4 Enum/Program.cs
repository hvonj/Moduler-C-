using System;
using static Module6._4_Enum.Person;

namespace Module6._4_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Lisa = new Person
            {
                FirstName = "Lisa",
                LastName = "Karlsson",
                Birthday = "(1989, 11, 04)",
                Sport = PersonSport.Squash,
                Gender = PersonGender.Female
            };
            Console.WriteLine($"{Lisa.FirstName} is a {Lisa.Gender}");
            Console.WriteLine($"{Lisa.FirstName} likes to play {Lisa.Sport}");

            if (Lisa.Sport == PersonSport.Tennis)
            {
                Console.WriteLine($"{Lisa.FirstName} likes to play Tennis");
            }
            else
            {
                Console.WriteLine($"{Lisa.FirstName} doesnt like to play Tennis");
            }
            Console.WriteLine();

            Console.WriteLine("Here is a list of all sport enums: ");

            foreach (string Sport in Enum.GetNames(typeof(PersonSport)))
            {
                Console.WriteLine($"*{Sport}");
            }

            Console.Write("Enter a sport: ");
            string answer = Console.ReadLine();

            if (Enum.TryParse(answer, true, out PersonSport sport))
            {
                Console.WriteLine($"Oh, I know {sport}!");
            }
            else
            {
                Console.WriteLine($"I don't know the sport {answer}");
            }

        }
    }
}
