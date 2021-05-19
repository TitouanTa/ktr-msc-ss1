using ktr_msc_ss1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ktr_msc_ss1.Vues
{
    interface Movable
    {
        public void moveRight(Character character)
        {
            Console.WriteLine(character.Name + " : moves right");
        }

        public void moveLeft(Character character)
        {
            Console.WriteLine(character.Name + " : moves left");
        }

        public void moveForward(Character character)
        {
            Console.WriteLine(character.Name + " : moves forward");
        }

        public void MoveBack(Character character)
        {
            Console.WriteLine(character.Name + " : moves bacward");
        }
    }
}
