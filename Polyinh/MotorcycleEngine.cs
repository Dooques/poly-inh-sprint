using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyinh
{       
    internal class MotorcycleEngine:Engine
    {
        public MotorcycleEngine(FuelType fuelType = FuelType.Leaded, int horsepower = 100):base(fuelType, horsepower)
        {

        }
    }
}
