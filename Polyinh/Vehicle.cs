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
        public Engine EngineType { get; private set; }

        public Vehicle(string make, string model, Engine engineType) 
        {
            Make = make;
            Model = model;
            EngineType = engineType;
        }

        public void Drive()
        {
            if (EngineType.Running)
            {
                Accelerate();
            }
            else 
            {
                Console.WriteLine($"{Make} {Model} is not running");
            }
                
        }

        public abstract void Accelerate();

        public void StartEngine() { EngineType.Start();  }
    }
}
