using Pokemonnnn_battleee.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Dialga : Pokemon
    {
        public Dialga()
        {
            base.name = "Dialga";
            base.height = "17.09";
            base.weight = "1505.8";

            base.hp = 100;
            base.atk = 120;
            base.def = 120;
            base.spd = 90;

            base.gender = Gender.unknown;
            base.category = "Temporal";
            base.abilities = Abilities.Pressure;
            base.type = new List<PokemonType> { PokemonType.dragon, PokemonType.steel };
            base.imagename = Resources._483;
        }
    }
}
