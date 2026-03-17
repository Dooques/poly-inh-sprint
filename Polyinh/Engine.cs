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
        public int HorsePower { get; private set; }
        public FuelType FuelType { get; private set; }

        public Engine(FuelType fuelType, int horsepower)
        {
            this.FuelType = fuelType;
            HorsePower = horsepower;
        }

        public void Start() { Running = true; }


    }
}
