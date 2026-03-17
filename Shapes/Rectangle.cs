using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double width, double length)
        {
            Length = length;
            Width = width;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

    }
}
