using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class GrassType : PokeType
    {   

        public GrassType(Elements weak, Elements strong) : base(weak, strong)
        {
            AttackList.Add("Scratch", new Attack("Scratch",2,Elements.Normal));
            AttackList.Add("Vine Whip", new Attack("Vine Whip", 2, Elements.Fire));


        }
    }
}
