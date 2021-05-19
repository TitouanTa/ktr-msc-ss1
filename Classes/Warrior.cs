using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1.Classes
{
    class Warrior : Character
    {
        public Warrior(string RPGClass,int Life, int Agility, int strength, int wit)
        {
            this.RPGClass = "Warrior";
            this.Life = 100;
            this.Agility = 8;
            this.Strength = 10;
            this.Wit = 3;
        }
        public Warrior(string nom)
        {
            this.Name = nom;
            this.RPGClass = "Warrior";
            this.Life = 100;
            this.Agility = 8;
            this.Strength = 10;
            this.Wit = 3;
        }
    }
}
