using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1.Classes
{
    class Character
    {
        protected string _name = "John Terry";
        protected string _RPGClass = "Mage";
        protected int _life = 50;
        protected int _agility = 2;
        protected int _strength = 2;
        protected int _wit = 2;

        public Character(string name, string rPGClass, int life, int agility, int strength, int wit)
        {
            _name = name;
            _RPGClass = rPGClass;
            _life = life;
            _agility = agility;
            _strength = strength;
            _wit = wit;
        }
        public Character()
        {

        }

        public string Name { get => _name; set => _name = value; }
        public string RPGClass { get => _RPGClass; set => _RPGClass = value; }
        public int Life { get => _life; set => _life = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Wit { get => _wit; set => _wit = value; }

        public void Attack(string scream)
        {
            Console.WriteLine(_name);
            Console.WriteLine(_RPGClass);
            Console.WriteLine(_life);
            Console.WriteLine(_agility);
            Console.WriteLine(_strength);
            Console.WriteLine(_wit);
            Console.WriteLine(_name + " : " + scream);
        }

    }
}
