using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pokemon
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public PokeType PokeType { get; set; }

        public Pokemon(int health, string name, PokeType pokeType) 
        { 
            Health = health;
            Name = name;
            PokeType = pokeType;

        }

        public override string ToString()
        {
            return ($"{Name} is a {PokeType} and has {Health} health");
        }
    }
}
