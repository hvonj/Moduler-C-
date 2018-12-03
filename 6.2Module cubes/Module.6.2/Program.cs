using System;

namespace Module._6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            mycube.CalculateVolume();
            supercube.CalculateVolume();

            mycube.CalculateArea();
            supercube.CalculateArea();

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine($"The volume of the cube is {mycube.CalculateVolume()}");
            Console.WriteLine($"The volume of the cube is {supercube.CalculateVolume()}\n");

            Console.WriteLine($"The area of the cube is {mycube.CalculateArea()}");
            Console.WriteLine($"The area of the cube is {supercube.CalculateArea()}");
        }
    }
}
////double volume = mycube.CalculateVolume();
//Console.WriteLine($"Volume: {volume}");

// double supervolume = supercube.CalculateVolume();
//Console.WriteLine($"Volume: {supervolume}");