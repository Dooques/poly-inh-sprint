using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Sphere:Shape3D
    {
        public Sphere(Circle shape) : base (shape)
        {

        }

        public override double CalculateVolume()
        {
            throw new NotImplementedException();
        }
    }
}
