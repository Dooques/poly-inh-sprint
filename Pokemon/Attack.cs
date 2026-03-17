using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Attack
    {
        public string Name;
        public int Damage;
        public Elements Type;

        public Attack(string name, int damage, Elements type) 
        {
            Name = name;
            Damage = damage;
            Type = type;
        } 



    }
}
