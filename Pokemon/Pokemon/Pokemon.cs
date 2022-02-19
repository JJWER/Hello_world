using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Pokemon
    {
        protected string name;
        protected string height;
        protected string weight;
        protected Gender gender;
        protected string category;
        protected Abilities abilities;
        protected new List<PokemonType> type;
        protected Bitmap imagename;



        public string getName()
        {
            return name;
        }
        public Bitmap getImage()
        {
            return imagename;
        }
    }

    enum PokemonType
    {
        steel,
        dragon,
        Ground,
        Water,
        Dark,

    }
    enum Abilities
    {
        Drought,
        Pressure,
        Torrent,

    }
    enum Gender
    {
        male,
        female,
        unknown,

    }
}


