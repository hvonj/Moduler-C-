using System;
using System.Collections.Generic;
using System.Text;

namespace Module._6._2
{
    class Cube
    {
        public int Depth { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public Cube(int x, int y, int z)
        {
            Depth = x;
            Height = y;
            Width = z;
        }
        public double CalculateVolume()
        {
            double volume = (Depth * Height * Width);
            return volume;
        }
        public double CalculateArea()
        {
            double area = (Height * Width);
            return area;
        }
    }
            
}
