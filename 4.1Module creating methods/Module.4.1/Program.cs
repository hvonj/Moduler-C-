using System;

namespace Module._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ffff = AskForNames();

            string[] gggg = CreateArrayOfPeople(ffff);

            RespondToUser(gggg);

        }
        private static string AskForNames()
        {
            Console.Write("Enter names seperated by comma (e.g Maria, Peter, Lisa): ");
            string names = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            return names;
        }

        private static string[] CreateArrayOfPeople(string xxx)
        {
            string[] aaa = xxx.Split(',');
            return aaa;
        }

        private static void RespondToUser(string[] bbbb)
        {
            bool isValid = true;

            while
                (isValid == true)
            {

            }

            if (bbbb.Length == 1 && string.IsNullOrWhiteSpace(bbbb[0]))
            {
                Console.WriteLine("The list don't contain any names!");
                isValid = false;
            }
            else
            {
                foreach (string name in bbbb)
                {
                    if (name.Length < 2 || name.Length > 9)
                    {
                        Console.WriteLine("A person can only have 2 to 9 letters!");
                        isValid = false;
                    }
                }
            }

            //

            if (isValid == true)
            {
                for (var i = 0; i < bbbb.Length; i++)
                {
                    bbbb[i] = bbbb[i].Trim();
                }

                foreach (string name in bbbb)
                {

                    Console.WriteLine($"***SUPER-{name.ToUpper()}***");


                }
            }



        }


    }



}
