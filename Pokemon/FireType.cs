using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class FireType : PokeType
    {   

        public FireType(Elements weak = Elements.Water, Elements strong = Elements.Grass) : base(weak, strong)
        {
            AttackList.Add("Scratch", new Attack("Scratch",2,Elements.Normal));
            AttackList.Add("Fireball", new Attack("Fireball", 2, Elements.Fire));


        }
    }
}
