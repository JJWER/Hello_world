using Pokemons_battlesss.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons_battlesss
{
    internal class Groudon : Pokemon
    {
        public Groudon() {
            base.name = "Groudon";
            base.height = "11.06";
            base.weight = "2064.4";
            base.gender = Gender.unknown;
            base.category = "Continent";
            base.abilities = Abilities.Drought;
            base.type = new List<PokemonType> { PokemonType.Ground };
            base.imagename = Resources._383;
        }
    }
}
