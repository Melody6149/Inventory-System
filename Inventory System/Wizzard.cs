using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Wizzard : Character
    {
        public Wizzard(string name) : base (name)
        {
            _health = 100;
            _mana = 100;
            _strenght = 5;
            _dexterity = 5;
            _wisdom = 10;
        }
    }
}
