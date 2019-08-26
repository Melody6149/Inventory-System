using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Character
    {
        private string _name = "0";
        private int _level = 1;
        private int _exp = 0;
        private int[] _requiredXP = { 100, 300, 600, 1000 }; // array used to have multiple reqired xp
        
        private Inventory _inventory = new Inventory();

        protected int _health = 100;
        protected int _mana = 100;
        protected int _strenght= 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;

        public Character(string name)
        {
            _name = name;

        }


        public string name()
        {
            return _name;
        }
        public int experiance
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
        public void Print() //function that runs code under this
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level: " +_level);
            Console.WriteLine("Exp: " + _exp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Mana: " + _mana);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdome: " + _wisdom);

        }
        public void openinventory()
        {
            _inventory.Menu();
        }
        


    }
}
