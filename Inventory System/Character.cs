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
        private int[] _requiredXP = { 100, 300, 600, 1000 };




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
        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Level" +_level);
            Console.WriteLine(_exp);
        }
        


    }
}
