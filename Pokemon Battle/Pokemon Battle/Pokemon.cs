using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Battle
{
    public class Pokemon
    {
        protected string name;
        protected double height;
        protected double weight;

        protected Gender gender;
        protected Category category;
        protected Abilities abilities;
        protected Bitmap image;
        protected Type type;
        protected Type weakness;

        public string getName() {
            return this.name;
        }

        public Bitmap getImage() {
            return this.image;
        }
    }
    public enum Gender
        {
            male,
            female,
        }
    public enum Category
        {
            mouse, Temporal
    }
    public enum Abilities
        {
            static_, pressure_
    }
    public enum Type
        {
            electic, ground, steel, dragon,
            fighting
    }
    
}
