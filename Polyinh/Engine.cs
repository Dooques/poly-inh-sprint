using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyinh
{
    public abstract class Engine
    {
        public bool Running { get; private set; }
        int Horsepower;
        FuelType FuelType;

        public Engine(FuelType fuelType, int horsepower)
        {
            this.FuelType = fuelType;
            Horsepower = horsepower;
        }

        public void Start() { Running = true; }
    }
}
