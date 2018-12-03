using System;

namespace NestledLoops
{
    class Program
    {

        static void Main(string[] args)
        {
            DrawSquare(3);
            Console.WriteLine();
            DrawSquare(7);
            Console.WriteLine();
            DrawSquare(5);
        }
        static void DrawSquare(int antal)
        {
            for (int x = 0; x < antal; x++) // Loop1 kör så många gånger x är mindre än antal. 
            { // inget mer än att gå in i loop 2.
                for (int y = 0; y < antal; y++)
                {
                    Console.Write("0  ");
                }
                Console.WriteLine();
            }

        }
    }
}
