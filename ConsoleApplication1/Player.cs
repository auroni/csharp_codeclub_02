using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Player
    {
        private string name = "";
        private int hitpoints = 0;
        private int attack = 0;

        public Player(string givenName, int giveHP, int giveAttack)
        {
            name = givenName;
            hitpoints = giveHP;
            attack = giveAttack;
        }

        public void TakeDamage()
        {
            Console.WriteLine(name + " takes damage");

            hitpoints -= attack;
        }

        public void Print()
        {
            Console.WriteLine("Current health: " + hitpoints);
            Console.WriteLine("\nWhat next?\n<Attack> <Defend> <Quit>");
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int HitPoints
        {
            get
            {
                return hitpoints;
            }
            set
            {
                hitpoints = value;
            }
        }
        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

    }
}
