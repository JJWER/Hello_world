using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemonnnn_battleee
{
    internal class Pokemon
    {
        protected int hp;
        protected int atk;
        protected int def;
        protected int spd;

        protected string name;
        protected string height;
        protected string weight;

        protected Gender gender;
        protected string category;
        protected Abilities[] abilities;
        protected Bitmap image;
        protected Type[] type;
        protected Bitmap imagename;



        public string getName()
        {
            return name;
        }
        public Bitmap getImage()
        {
            return imagename;
        }
        public int getHP() { return hp; }
        public void setHP(int newHP) { this.hp = newHP; }
        public int getAtk() { return atk; }
        public int getDef() { return def; }
        public int getSpd() { return spd; }
        public void attackPokemon(ref Pokemon enemy)
        {
            int damage = this.atk - enemy.getDef();
            int newHP = enemy.getHP() - damage;
            enemy.setHP(newHP);

        }

        public enum Type
        {
            steel,
            dragon,
            Ground,
            Water,
            Dark,
            Ghost,
            Normal,
            Psychic,
        }
        public enum Abilities
        {
            Drought,
            Pressure,
            Torrent,
            Multitype,
            Prism_Armor,
        }
        public enum Gender
        {
            male,
            female,
            unknown,
        }
    }
}

