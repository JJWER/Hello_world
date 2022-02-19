using Pokemons_battlesss.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons_battlesss
{
    internal class Greninja : Pokemon
    {
        public Greninja() {
            base.name = "Grenninja";
            base.height = "4.11";
            base.weight = "88.2";
            base.gender = Gender.male;
            base.category = "Ninja";
            base.abilities = Abilities.Torrent;
            base.type = new List<PokemonType> { PokemonType.Water, PokemonType.Dark };
            base.imagename = Resources._658;
        }
    }
}
