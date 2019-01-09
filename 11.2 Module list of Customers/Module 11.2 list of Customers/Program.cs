using Module_11._2_list_of_Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = GetCustomerInput();
            List<Personal> customerlist = CreateCustomerList(lines);
            WorkWithList(customerlist);
        }

        private static string[] GetCustomerInput()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Projekt\AcceleratedLearning\CsharpExercises\Module 11.2 list of Customers\test\test.txt");

            return lines;
        }

        private static List<Personal> CreateCustomerList(string[] lines)
        {
            var customerlist = new List<Personal>();

            foreach (var item in lines)
            {
                var x = new Personal();

                string[] split = item.Split(',');
                x.ID = int.Parse(split[0]);
                x.FirstName = split[1];
                x.LastName = split[2];
                x.Email = split[3];
                x.Gender = split[4];
                x.Age = int.Parse(split[5]);
                customerlist.Add(x);
            }
            return customerlist;
        }

        private static void WorkWithList(List<Personal> customerlist)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorted list by age:");
            Console.ForegroundColor = ConsoleColor.Gray;

            var agelist = customerlist.OrderBy(x => x.Age).ToList();

            foreach (var cust in agelist)
            {
                CustomerOutput(cust);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nSorted list by name:");
            Console.ForegroundColor = ConsoleColor.Gray;

            var namelist = customerlist.OrderBy(x => x.FirstName).ToList();
            foreach (var cust in namelist)
            {
                CustomerOutput(cust);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nMen older than 35: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            var men35 = namelist.Where(x => x.Age >= 35 && x.Gender == "Male").ToList();
            foreach (var cust in men35)
            {
                CustomerOutput(cust);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nManipulated: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var cust in men35)
            {

                Manipulate(cust);
            }

        }

        static void CustomerOutput(Personal cust)
        {
            Console.WriteLine($"{cust.FirstName}\t\t{cust.Age}\t\t {cust.Gender}");
        }
        static void Manipulate(Personal cust)
        {
            Console.WriteLine($"{cust.FirstName.ToUpper()}\t\t{cust.Age + 1000}\t\t {cust.Gender}");
        }

    }
}

