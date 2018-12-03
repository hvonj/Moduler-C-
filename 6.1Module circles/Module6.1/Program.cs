using System;

namespace Module6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);
            Circle ali = new Circle("Ali", 5);

            bob.SayHello();
            lisa.SayHello();
            ali.SayHello();

            Console.WriteLine();

            bob.WriteArea();
            lisa.WriteArea();
            ali.WriteArea();

            Console.WriteLine();
        }
}    }
