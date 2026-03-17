using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyinh
{
    public abstract class Vehicle
    {
        public string Make { get; private set; } 
        public string Model { get; private set; }
        public int Speed { get; private set; }

        public  Vehicle(string make, string model, int speed) 
        {
            Make = make;
            Model = model;
            Speed = speed;
        }
    }
}
