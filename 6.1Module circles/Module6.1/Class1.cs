using System;
using System.Collections.Generic;
using System.Text;

namespace Module6._1
{
    class Circle
    {
        public string Name { get; set; } //PROPERTIES
        public int Radie { get; set; }

        public Circle(string n, int r) //för att vi har skrivit ("Bob", 8); i main // CONSTRUCTOR    
        {
            Name = n;
            Radie = r;
        }

        public void SayHello()
        {
            Console.WriteLine($"I am a circle with the name {Name}!");
        
        }
        public void WriteArea()
        {
            double area = (Radie * Radie) * Math.PI; //behöver inte använda Return för att vi inte ska skicka tillbaka någon info, vi skickar ut info genom CW.

            Console.WriteLine($"My name is {Name} and I have a radius of {Radie} and an area of {area:.##}."); // för att få talet i två decimaler.

        }


    }
}
