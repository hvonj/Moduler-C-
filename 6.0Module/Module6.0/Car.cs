using System;
using System.Collections.Generic;
using System.Text;

namespace Module6._0
{
    class Car
    {
        public int Weight { get; set; } 
        public string Color { get; set; }

        public Car(string c, int w)
        {
            Color = c;
            Weight = w;
        }

        public Car() //konstruktor
        {
            Color = "rosa";
            Weight = 900;
        }

        //public void SetColor(string xxx)
        //{
        //    color = xxx;
        //}
        //public string GetColor()
        //{
        //    return color;
        //}
        //public int GetWeight()
        //{
        //    return weight;
        //}
    }   
}
