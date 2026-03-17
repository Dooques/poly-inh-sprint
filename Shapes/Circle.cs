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
        public Circle() : base()
        {

        }

        public override double CalculateArea()
        {
            throw new NotImplementedException();
        }

    }
}    
