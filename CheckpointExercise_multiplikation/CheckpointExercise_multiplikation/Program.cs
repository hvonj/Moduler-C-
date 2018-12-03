using System;

namespace Multiplikation
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplikation(5);
        }

        static void Multiplikation(int tal)
        {
            for (int x = 1; x <= tal; x++)
            {
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine($"{x} * {y} = {x * y}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}


