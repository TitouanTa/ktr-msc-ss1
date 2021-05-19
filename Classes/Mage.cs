using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1.Classes
{
    class Mage : Character
    {
        public Mage(string RPGClass, int Life, int Agility, int strength, int wit)
        {
            this.RPGClass = "Mage";
            this.Life = 70;
            this.Agility = 10;
            this.Strength = 3;
            this.Wit = 10;
        }
        public Mage(string nom)
        {
            this.Name = nom;
            this.RPGClass = "Mage";
            this.Life = 70;
            this.Agility = 10;
            this.Strength = 3;
            this.Wit = 10;
        }
    }
}
