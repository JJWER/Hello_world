using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Necrozma : Pokemon
    {
        public Necrozma()
        {
            base.name = "Necrozma";
            base.height = "7.10";
            base.weight = "507.1";

            base.hp = 79;
            base.atk = 107;
            base.def = 101;
            base.spd = 79;

            base.gender = Gender.unknown;
            base.category = "Prism";
            base.abilities = new Abilities[] { Abilities.Prism_Armor };
            base.type = new Type { Type.Psychic};
            base.imagename = Resources._800;
        }
    }
}
