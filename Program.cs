using ktr_msc_ss1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktr_msc_ss1
{
    class Program
    {
        static void Main()
        {
            //Character mage = new Character("Harry Potter","Mage");
            //mage.Attack("wand");
            Warrior warrior = new Warrior("Aragorn");
            warrior.Attack("sword");
            Mage mage = new Mage("Harry Potter");
            mage.Attack("wand");
            Console.Read();
        }
    }
}
