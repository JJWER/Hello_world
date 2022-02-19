using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Greninja : Pokemon
    {
        public Greninja()
        {
            base.name = "Grenninja";
            base.height = "4.11";
            base.weight = "88.2";

            base.hp = 72;
            base.atk = 95;
            base.def = 67;
            base.spd = 122;

            base.gender = Gender.male;
            base.category = "Ninja";
            base.abilities = new Abilities[] { Abilities.Torrent };
            base.type = new Type[] { Type.Water, Type.Dark };
            base.imagename = Resources._658;
        }
    }
}
