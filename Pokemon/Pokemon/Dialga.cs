using Pokemon.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Dialga : Pokemon
    {
        public Dialga()
        {
            base.name = "Dialga";
            base.height = "17.09";
            base.weight = "1505.8";
            base.gender = Gender.unknown;
            base.category = "Temporal";
            base.abilities = Abilities.Pressure;
            base.type = new List<PokemonType> { PokemonType.dragon, PokemonType.steel };
            base.imagename = Resources._483;
        }
    }
}