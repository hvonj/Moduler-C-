using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Uppg_10_5_Dictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<int, string> products = AskForProducts();
            DisplayProductDictionary(products);
        }

        private static Dictionary<int, string> AskForProducts()
        {
            Dictionary<int, string> products = new Dictionary<int, string>();

            while (true)
            {
                Console.Write("Enter product ID and Name: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string input = Console.ReadLine();
                Console.ResetColor();

                if (string.IsNullOrWhiteSpace(input))
                {
                    return products;
                }
                else
                {
                    if (Regex.IsMatch(input, @"^[0-9]+,[a-zA-ZåäöÅÄÖ]+$")  == false) //input först - pattern sen. Om SANT/matchar då... in i IF satsen!
                                                                                     //if (Regex.IsMatch(input, @"^[0-9]+,[a-zA-ZåäöÅÄÖ]+$") (==false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input");
                        Console.ResetColor();
                        continue;
                    }

                    string[] splitted = input.Split(',');
                    int iD = int.Parse(splitted[0]);
                    string product = splitted[1];

                    if (products.ContainsKey(iD))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The product list already contains the id {iD}");
                        Console.ResetColor();
                        continue;
                    }
                    if (products.ContainsValue(product))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The product list already contains the value {product}");
                        Console.ResetColor();
                        continue;

                    }
                    else
                    {
                        products.Add(iD, product);
                        //vi vill inte return något här pga loopen ska fortsätta.
                    }
                }

            }

        }
        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            foreach (var thing in products)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Product id= {thing.Key} and name= {thing.Value}");
                Console.ResetColor();
            }
        }
    }
}
