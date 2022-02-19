using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Arceus : Pokemon
    {
        public Arceus()
        {
            base.name = "Arceus";
            base.height = "10.06";
            base.weight = "705.5";

            base.hp = 120;
            base.atk = 120;
            base.def = 120;
            base.spd = 120;

            base.gender = Gender.unknown;
            base.category = "Alpha";
            base.abilities = new Abilities[] { Abilities.Multitype };
            base.type = new Type[] { Type.Normal };
            base.imagename = Resources._493;
        }
    }
}
