using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._2_Tv_data
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Show> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
        }


        private static List<Show> GetShowsFromTextFile()
        {

            List<Show> listofShows = new List<Show>();

            string[] lines = System.IO.File.ReadAllLines(@"C:\Projekt\AcceleratedLearning\CsharpExercises\11.2 Tv-data\test\Tvtablå.txt");

            foreach (var line in lines)
            {
                var x = new Show();
                string[] newlines = line.Split('*');
                x.Channel = newlines[0];
                x.Starttime = TimeSpan.Parse(newlines[1]);
                x.Name = newlines[2];
                listofShows.Add(x);
            }
            return listofShows;
        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            Console.WriteLine("ALLA TITLAR \n");

            foreach (var show in allShows) // om man vill använda Linq så kan man använda .Select
            {
                Console.WriteLine(show.Name);
            }

            Console.WriteLine("\nPROGRAM SOM BÖRJAR SENARE ÄN 21:00 \n");

            List<Show> after21 = allShows.Where(x => x.Starttime > new TimeSpan(21, 0, 0)).ToList();

            foreach (var show in after21)
            {
                Console.WriteLine(show.Channel + " " + show.Starttime + " " + show.Name);
            }

            Console.WriteLine();
            Console.WriteLine("PROGRAM FRÅN SVT2 I KRONOLOGISK ORDNING\n");

            List<Show> svt2 = allShows.Where(x => x.Channel == "SVT2").OrderByDescending(x => x.Starttime).ToList();

            foreach (var item in svt2)
            {
                Console.WriteLine(item.Channel+ " "+ item.Starttime + " " + item.Name);
            }

            Console.WriteLine();
            Console.WriteLine("FINNS PROGRAMMET 'KULTURNYHETERNA?'\n");

            List<Show> kn = allShows.Where(x => x.Name == "Kulturnyheterna").ToList();
            if (kn.Count >= 1)
            {
                Console.WriteLine("JA");
            }
            else
            {
                Console.WriteLine("NEJ");
            }

            Console.WriteLine();
            Console.WriteLine("FINNS PROGRAMMET 'ENSAM PAPPA SÖKER?'\n");

            List<Show> eps = allShows.Where(x => x.Name == "Ensam pappa söker").ToList();
            if (eps.Count >= 1)
            {
                Console.WriteLine("JA");
            }
            else
            {
                Console.WriteLine("NEJ");
            }

            Console.WriteLine("\nALLA PROGRAM SOM BÖRJAR 20:00 \n");

            List<Show> tjugonollnoll = allShows.Where(x => x.Starttime == new TimeSpan(20, 0, 0)).ToList();

            foreach (var show in tjugonollnoll)
            {
                Console.WriteLine(show.Channel + " " + show.Starttime + " " + show.Name);
            }

            Console.WriteLine();
            Console.WriteLine("ALLA TITLAR MED STORA BOKSTÄVER\n"); //Header("ALLA....."); istället för cw

            foreach (var item in allShows)
            {

                Console.WriteLine(item.Name.ToUpper());
            }

            Console.WriteLine();
            Console.WriteLine("ALLA KANALER\n");

            foreach (string item in allShows.Select(x=>x.Channel).Distinct()) //Linq
            {
                Console.WriteLine(item); // detta PLUS varför blir det ? istället för åäö ?!?!
            }
        }

    }
}