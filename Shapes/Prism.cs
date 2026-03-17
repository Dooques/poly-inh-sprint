using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    
    public class Prism:Shape3D
    {
        public double Height { get; set; }
        public Prism(Triangle shape) : base(shape) 
        {  
            Height = shape.Height; 
        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
