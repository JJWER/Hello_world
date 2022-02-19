using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
            base.name = "Mewtwo";
            base.height = "6.07";
            base.weight = "269.0";

            base.hp = 106;
            base.atk = 110;
            base.def = 90;
            base.spd = 130;

            base.gender = Gender.unknown;
            base.category = "Genetic";
            base.abilities = new Abilities[] { Abilities.Pressure}
            base.type = new Type[] { Type.Psychic };
            base.imagename = Resources._150;
        }
    }
}
