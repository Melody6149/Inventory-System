using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Creature
    {
        protected int _health = 10;
        protected int _maxHealth = 10;
        protected int _experiance = 0;
        public virtual void Fight(Creature target)
        {

        }


        public virtual void Fight(Creature[] targets)
        {

        }

        public virtual int GetDefense()
        {
            return 0;
        }

        public virtual int GetDamage()
        {
            return 0;
        }


        public virtual string GetName()
        {
            return "no one will see this name";
        }
        public virtual int experience
        {
            get
            {
                return _experiance;
            }
            set
            {
                _experiance = value;
            }
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
         
       public virtual void Print()
        {

        }

}

}
