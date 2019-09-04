using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Character : Creature
    {
        private string _name = "0";
        private int _level = 1;
        private int _exp = 0;
        private int[] _requiredXP = { 100, 300, 600, 1000 }; // array used to have multiple reqired xp
        
        private Inventory _inventory = new Inventory();

        
        protected int _mana = 100;
        protected int _strenght= 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;

        public Character(string name)
        {
            _name = name;
            
            
        }


        public override string GetName()
        {
            return _name;
        }
        public int experiance  //for experiance
            //uses array to increase about of exp needed
        {
            get
            {
                return _exp;
            }
            set
            {
                _exp = value;
                Console.WriteLine(_name + "gained experaince. Now has" + _exp);
                if (_level <= _requiredXP.Length)
                {
                    if (_exp >= _requiredXP[_level - 1])
                    {
                        _level++;
                        Console.WriteLine(_name + " is now level " + _level);
                    }
                }
            }
        }
        public override void Print() //function that runs code under this
        {
            Console.WriteLine();
            Console.WriteLine(_name);
            Console.WriteLine("Level: " +_level);
            Console.WriteLine("Exp: " + _exp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdome: " + _wisdom);
            Console.WriteLine("Combat damage " + (GetDamage()));

        }
        public void openinventory()
        {
            _inventory.Menu();
        }
        
        public override int GetDamage()
        {
            return _strenght + _inventory.GetItemDamage(); // allows rest of program to see the damage of the player
        }


        public override int GetDefense()
        {
            return _inventory.GetItemDefense();
        }
        public override void Fight(Creature target)
        {
            if (Health == 0)
            {
                return;
            }

            int damage = GetDamage(); // get damage of attacking monster
            damage = damage - target.GetDefense(); // alows for defense to be taken from attack from attacking creature
            
            target.Health -= damage; //

            Console.WriteLine(GetName() + " attacks! " + target.GetName() + " now has " + target.Health);
            Console.WriteLine();
            Console.ReadKey();

        }
        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }

            bool validInput = false;
            while (!validInput)
            {
                Console.WriteLine("\nWhio will " + GetName() + " fight?");
                //Print menu

                for (int i = 0; i < targets.Length; i++) // shows names of targets
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

