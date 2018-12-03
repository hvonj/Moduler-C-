using System;


namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("When did you go to bed yesterday?");
            int startTime = int.Parse(Console.ReadLine());

            Console.WriteLine("When did you wake up?");
            int endTime = int.Parse(Console.ReadLine());



            TimeSpan duration = DateTime.Parse(endTime).Subtract(DateTime.Parse(startTime));

            Console.WriteLine(duration);
            Console.ReadLine();

        }
    }
}

