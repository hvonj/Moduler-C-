using System;
using System.Text.RegularExpressions;

namespace _8._3_Module_Animals
{
    class Program
    {
        static string StringOfAnimals;

        static string[] parseAnimals(string StringOfAnimals) //array
        {
            string[] animals = StringOfAnimals.Split(',');
            if (string.IsNullOrWhiteSpace(StringOfAnimals)) //kollar om det är tomt
            {
                throw new ArgumentException("The list must contain at least one animal");
            }

            foreach (var thing in animals)
            {
                string animal = thing.Trim(); //tar bort mellanslag
                if (animal.Length >20)
                {
                    throw new ArgumentException($"The animal {animal} contains too many letters");
                }
                if (!Regex.IsMatch(animal, @"^[a-zA-ZåäöÅÄÖ]+$")) //OM den innehåller dessa tecken så...(! betyder falskt) Den ska larma om något annat än dessa tecken är med!
                {
                    throw new ArgumentException($"The animal {animal} contains invalid letters");

                }
                if (animal.Length == 0)
                {
                    throw new ArgumentException("One of the animals doesnt contain any letters");
                }

            }
            return animals;  

            
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a list of animals: ");

                try
                {
                    StringOfAnimals = Console.ReadLine();

                    var list = parseAnimals(StringOfAnimals);

                    Console.WriteLine($"The list contains {list.Length} animals");

                    return;
                }
                catch (ArgumentException ex) //den behöver inte vara def. utan innehåller info-fel. Typ en "variabel"
                {
                    Console.WriteLine(ex.Message);
                }
            }

            
           
            
            
        }
    }
}
