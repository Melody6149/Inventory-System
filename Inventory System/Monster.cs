using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Monster
    {
        private string _name = "";
        private int _health = 1;
        private int _damage = 0;
        private int _maxHealth = 10;



        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _maxHealth = health;
        }
        public string GetName()
        {
            return _name;
        }

        public int GetDamage()
        {
            return _damage;
        }


        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value; //sets health to new value
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
                if (_health < 0)
                {
                    _health = 0;
                }
            }


        }



        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("the monster " + _name);
            Console.WriteLine("The mosters health is " + _health);
            Console.WriteLine("The monsters attack is " + _damage);

        }


        public void Fight(Monster target)
        {
            if (Health == 0)
            {
                return;
            }

            int damage = GetDamage(); // get damage of attacking monster

            target.Health -= damage; //

            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " now has " + target.Health);
            Console.WriteLine();
            Console.ReadKey();

        }
        public void Fight(Monster[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("/nWhio will " + GetName() + " fight?");
                //Print menu
                
                for (int i = 0; i < targets.Length; i ++) // shows names of targets
                {
                    Console.WriteLine(i + " " + targets[i].GetName());
                }
                Console.WriteLine("");
                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input); // stores your choices
                if (choice >= 0 && choice < targets.Length)
                {
                    validInput = true;
                    Fight(targets[choice]); // monster fights target

                }
            }
        }
       
        }

    }

