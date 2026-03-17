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
        { }

        public override double CalculateVolume()
        {
            var circleShape = (Circle)BaseShape;
            var firstStep = Math.Pow(circleShape.Radius, 3);
            var secondStep = firstStep * Math.PI;
            var thirdStep = secondStep * (4.0 / 3.0);
            return thirdStep;
        }
    }
}
