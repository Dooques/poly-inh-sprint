using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
           return Math.PI * (Radius * Radius);
        }

        public double GetRadius()
        {
            return Radius;
        }

    }
}    
