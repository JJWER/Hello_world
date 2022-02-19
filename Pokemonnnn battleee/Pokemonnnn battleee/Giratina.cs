using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Giratina : Pokemon
    {
        public Giratina()
        {
            base.name = "Giratina";
            base.height = "14.09";
            base.weight = "1653.5";

            base.hp = 150;
            base.atk = 120;
            base.def = 100;
            base.spd = 90;

            base.gender = Gender.unknown;
            base.category = "Renegade";
            base.abilities = new Abilities[] { Abilities.Pressure };
            base.type = new Type[] { Type.dragon, Type.Ghost };
            base.imagename = Resources._487;
        }
    }
}
