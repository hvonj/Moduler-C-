using System;
using System.Collections.Generic;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Shape> shapes = AskUserForInput();
            PrintShapes(shapes);

        }

        private static List<Shape> AskUserForInput()
        {
            List<Shape> shapes = new List<Shape>();

            List<Triangle> triangles = new List<Triangle>();
            List<Rectangle> rectangles = new List<Rectangle>();
            List<Circle> circles = new List<Circle>();

            string input;

            //while-loop tills man matar in D

            do
            {
                Console.Write("Select (T)riangle, (R)ectangle, (C)ircle or (D)one: ");
                input = Console.ReadLine();

                if (input == "T")
                {
                    var x = new Triangle();
                    shapes.Add(x);
                    Console.WriteLine("Enter height of triangle: ");
                    x.Height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width of triangle: ");
                    x.Width = int.Parse(Console.ReadLine());

                }
                else if (input == "R")
                {
                    var x = new Rectangle();
                    shapes.Add(x);
                    Console.WriteLine("Enter height of rectangle: ");
                    x.Height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width of rectangle: ");
                    x.Width = int.Parse(Console.ReadLine());

                }
                else if (input == "C")
                {
                    var x = new Circle();
                    shapes.Add(x);
                    Console.WriteLine("Enter radius of circle: ");
                    x.Radius = int.Parse(Console.ReadLine());
                }

            } while (input != "D");

            return shapes;
        }


        private static void PrintShapes(List<Shape> shapes)
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Shape item in shapes)
            {

                if (item.Name == "circle")
                {
                    Console.WriteLine($"I am a circle and my radius is {item.Radius}");
                }
                else
                Console.WriteLine($"I am a {item.Name} and my width is {item.Width} and my height is {item.Height}.");
            }
            
            Console.WriteLine();
            Console.ResetColor();
        }




    }
}
