using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class WaterType : PokeType
    {   

        public WaterType(Elements weak, Elements strong) : base(weak, strong)
        {
            AttackList.Add("Scratch", new Attack("Scratch",2,Elements.Normal));
            AttackList.Add("Water Cannon", new Attack("Water Cannon", 2, Elements.Fire));


        }
    }
}
