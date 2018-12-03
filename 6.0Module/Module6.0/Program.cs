using System;

namespace Module6._0
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Run();

        }
 
        static public void Run()
        {
            var c1 = new Car("blå", 1200);
            var c2 = new Car("röd", 800);
            var c3 = new Car();

            c2.Color = "gul";
            c2.Weight = 600;

           //c1.SetColor("blå");
           //c2.SetColor("röd");
           //c3.SetColor("grön");

            //var yyy = c1.GetColor();
            //var zzz = c2.GetColor();
            //var qqq = c3.GetColor();


            Console.WriteLine($"Färgen på bilen 'c1' är {c1.Color} och väger {c1.Weight}.");
            Console.WriteLine($"Färgen på bilen 'c2' är {c2.Color} och väger {c2.Weight}.");
            Console.WriteLine($"Färgen på bilen 'c3' är {c3.Color} och väger {c3.Weight}.");

            Console.WriteLine();

           //Console.WriteLine($"xxxxxx{c1.GetColor()}xxxxx{c1.GetWeight()}");
        }
    }
}
       
