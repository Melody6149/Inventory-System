using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Knight : Character
    {
        public Knight(string name) : base (name)
        {
            _health = 300;
            _mana = 30;
            _strenght = 7;
            _dexterity = 2;
            _wisdom = 5;
            _maxHealth = 300;
        }
    }
}
