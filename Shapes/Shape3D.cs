using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape3D
    {
        public Shape BaseShape { get; set; }

        public Shape3D(Shape shape) 
        {
            BaseShape = shape;
            
        }

        public abstract double CalculateVolume();
        
    }
}
