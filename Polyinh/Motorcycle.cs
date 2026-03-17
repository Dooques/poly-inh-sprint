using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyinh
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }
        public Motorcycle(string name, string model, int speed, bool hasSideCar, MotorcycleEngine engine) : base(name, model, engine)
        {
            HasSideCar = hasSideCar;
        }
    }
}
