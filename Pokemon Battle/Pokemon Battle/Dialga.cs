using Pokemon_Battle.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    internal class Dialga : Pokemon
    {
        public Dialga() {
            base.name = "Pikachu";
            base.height = 17.09;
            base.weight = 1505.8;

            base.gender = Gender.male;
            base.category = Category.Temporal;
            base.abilities = Abilities.pressure_;
            base.type = Type.steel, dragon;
            base.weakness = Type.fighting, ground;

            image = Resources._483;
        }
   
        
    }
}
