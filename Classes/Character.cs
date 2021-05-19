using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1.Classes
{
    class Character
    {
        string _name;
        string _RPGClass;
        int _life;
        int _agility;
        int _strength;
        int _wit;

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
        public Character(string name)
        {
            this._name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public string RPGClass { get => _RPGClass; set => _RPGClass = value; }
        public int Life { get => _life; set => _life = value; }
        public int Agility { get => _agility; set => _agility = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Wit { get => _wit; set => _wit = value; }

        public void Attack(string weapon)
        {
            
            if(this._RPGClass == "Warrior")
            {
                if (weapon == "hammer" || weapon == "sword")
                {
                    Console.WriteLine(_name);
                    Console.WriteLine(_RPGClass);
                    Console.WriteLine(_life);
                    Console.WriteLine(_agility);
                    Console.WriteLine(_strength);
                    Console.WriteLine(_wit);
                    Console.WriteLine("RRRR....");
                    Console.WriteLine("I'll beat you with my " + weapon);
                }
                else Console.WriteLine("I'm not fighting sorry");
            }
            if(this._RPGClass == "Mage")
            {
                if (weapon == "magic" || weapon == "wand")
                {
                    Console.WriteLine(_name);
                    Console.WriteLine(_RPGClass);
                    Console.WriteLine(_life);
                    Console.WriteLine(_agility);
                    Console.WriteLine(_strength);
                    Console.WriteLine(_wit);
                    Console.WriteLine("YAAAAAAAAA....");
                    Console.WriteLine("Feel the power of my ... " + weapon);
                }
                else Console.WriteLine("My magic is not ready, yet");
            }


        }

    }
}
