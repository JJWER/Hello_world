using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Groudon : Pokemon
    {
        public Groudon()
        {
            base.name = "Groudon";
            base.height = "11.06";
            base.weight = "2064.4";

            base.hp = 100;
            base.atk = 150;
            base.def = 140;
            base.spd = 90;

            base.gender = Gender.unknown;
            base.category = "Continent";
            base.abilities = new Abilities[] { Abilities.Drought };
            base.type = new Type[] { Type.Ground };
            base.imagename = Resources._383;
        }
    }
}
