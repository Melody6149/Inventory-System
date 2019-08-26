using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {



        private int _itemdamage = 0;
        private float _gold = 0.00f;
        private int _itemdefense = 0;
        private bool _WeaponEquiped = false; // tells game if weapon is equiped
        private string _armorsubmenuchoice = "";
        /* changed this to be easier to know what this is for
        True means weapon eqiuped
        False means weapon is not equiped
        */
        private string _weaponsubmenuChoice = ("0");
        /* 0 means no weapon 
         * 1 means your sword is equiped
         * 2 means your GreatSword
         * 3 means dagger
         * 4 means warhammer
          */

        




        private bool _armorEquiped = false;


        private int _potions = 0;

        private string _shopChoice = "";

        private int _Weaponweight = 0;  // for weight system
        private int _armorweight = 0;  // for weight system
        private int _maxweight = 100;    //sets max weight for player


        private AttackItem sword = new AttackItem("Master Sword", 10, 3);
        private AttackItem sword2 = new AttackItem("Not MasterSword", 10, 3);
        
        private AttackItem[] weapons;

        public Inventory()
        {
            AttackItem[] weaponBag = { sword, sword2 };
            weapons = weaponBag;
        }

        public int GetItemDamage() //function that returns item damage
        {
            return _itemdamage;
        }

        public int GetItemDefense() //function that returns item defense
        {
            return _itemdefense;
        }



        public void Menu()
        {
            String choice = "";

            while (choice != "0")
            {


                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("Your item damage is " + _itemdamage + ".");
                Console.WriteLine("You have " + _gold + " Gold.");
                Console.WriteLine("Your item defense is " + _itemdefense + ".");
                Console.WriteLine("You have " + _potions + " potions");
                Console.WriteLine("You have a max carry weight of " + _maxweight);
                Console.WriteLine("");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");

                Console.WriteLine("2: Give Gold");
                Console.WriteLine("3: Remove Gold");
                Console.WriteLine("4: Armor Equip submenu");
                Console.WriteLine("5: Shop");
                Console.WriteLine("6: use 1 potions");
                Console.WriteLine("");


                choice = Console.ReadLine();
                Console.WriteLine("");

                // check input
                if (choice == "1")
                {
                    EquipWeapon();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("How much gold");
                    float Goldamount = Convert.ToSingle(Console.ReadLine());
                    AddGold(Goldamount);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("How much gold");
                    float Goldamount = Convert.ToSingle(Console.ReadLine());
                    RemoveGold(Goldamount);
                }
                else if (choice == "4")
                {
                    armorsubmenu();
                }
                else if (choice == "5")
                {
                    shop();
                }
                else if (choice == "6")
                {

                    if (_potions == 0)
                    {
                        Console.WriteLine("you need potions to use them");
                        Console.ReadKey();
                    }


                    else if (_potions > 0)
                    {
                        usepotions();
                    }

                }
            }
        }



        public void EquipWeapon()
        {
            /*if (WeaponEquiped == 1)
                    //checks if your weapon is equiped or not equiped
                {
                    Console.WriteLine("You already have a weapon equiped");
                    Console.WriteLine();
                    return;
                }
                Console.WriteLine("Equiped a weapon");
                damage = 100; // sets damage to 100 
                This is old code*/

            /* 0 means no weapon 
         * 1 means your sword is equiped
         * 2 means your GreatSword
         * 3 means dagger
         * 4 means Warhammer */

            Console.WriteLine("What do you want to pick");
            Console.WriteLine("b: Exit");
            Console.WriteLine("0: unequipweapon");
            Console.WriteLine("1: Sword");
            Console.WriteLine("2: GreatSword");
            Console.WriteLine("3: Dagger");
            Console.WriteLine("4: Warhammer ");

            _weaponsubmenuChoice = Console.ReadLine();
            if (_weaponsubmenuChoice == "b")
            {
                return;
            }
            else if (_weaponsubmenuChoice == "1")
            {
                if (_armorweight + 30 >= _maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (_armorweight + 30 <= _maxweight) //checks if weapon weight and armor wieght are under the max weight
                {
                    Console.WriteLine("You picked the sword");
                    _itemdamage = 50; // sets damage
                    _Weaponweight = 30; //sets weapon weight for use when picking armor
                }


            }
            else if (_weaponsubmenuChoice == "2")
            {
                if (_armorweight + 80 >= _maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (_armorweight + 80 <= _maxweight)
                {
                    Console.WriteLine("You picked the GreatSword");
                    _itemdamage = 100;
                    _Weaponweight = 80;
                }

            }
            else if (_weaponsubmenuChoice == "3")
            {
                if (_armorweight + 10 >= _maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (_armorweight + 10 <= _maxweight)
                {
                    Console.WriteLine("You picked the Dagger");
                    _itemdamage = 90;
                    _Weaponweight = 10;
                }
            }
            else if (_weaponsubmenuChoice == "4")
            {
                if (_armorweight + 80 >= _maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (_armorweight + 80 <= _maxweight)
                {
                    Console.WriteLine("You picked the Warhammer");
                    _itemdamage = 99;
                    _Weaponweight = 80;
                }
            }
            else if (_weaponsubmenuChoice == "0") // making this for unequping a weapon in the same sub menu
            {
                UnequipWeapon(); //uses function for unequip weapon
            }

            Console.WriteLine("");
            Console.WriteLine("You now do " + _itemdamage + " damage");
            _WeaponEquiped = true; // lets game know a weapon is equiped
            Console.WriteLine("press any key to go back to main inventory");
            Console.ReadKey();
        }


        public void UnequipWeapon()

        {
            if (_WeaponEquiped == false)
            //checks if your weapon is rquiped or not equiped using bool. if it is false it runs this line
            {
                Console.WriteLine("You unequiped your imaginary weapon");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Unequiped a weapon");
            _itemdamage = 10; // sets damage to 10
            Console.WriteLine("");
            Console.WriteLine("You now do " + _itemdamage + " damage");
            _WeaponEquiped = false;
            Console.WriteLine();
            _Weaponweight = 0;

        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            _gold += amount;
            if (_gold < 0) // prevents gold from going below 0
            {
                _gold = 0;
            }
            Console.WriteLine("You have " + _gold + " gold.");
        }
        public void RemoveGold(float amount)
        {
            Console.WriteLine("You lost " + amount);
            _gold -= amount;
            if (_gold < 0) // prevents gold from going below 0
            {
                _gold = 0;
            }
            Console.WriteLine("You now have " + _gold + " gold");
        }
        public void armorsubmenu()
        {
            Console.WriteLine("Armor submenue");
            Console.WriteLine("0:unequip armor");
            Console.WriteLine("1: equip light armor");
            Console.WriteLine("2: Equip Heavy armor");
            // shows player their choices
            _armorsubmenuchoice = Console.ReadLine();
            if (_armorsubmenuchoice == "0")
            {
                if (_armorEquiped == false)
                {
                    Console.WriteLine("You removed your imaginary armor."); // does nothing and sends you back to main inventory menu
                    return;
                }
                Console.WriteLine("you removed your armor");
                _itemdefense = 0;
                _armorweight = 0;
            }
            else if (_armorsubmenuchoice == "1")
            {
                if (10 + _Weaponweight > _maxweight) // tells game to run this code if your stuff is to heavy
                {
                    Console.WriteLine("This armor is to heavy to be used with this weapon.");
                    Console.WriteLine("switch to a lighter weapon to use the armor ");
                }
                else if (10 + _Weaponweight < _maxweight)
                {
                    Console.WriteLine("You equiped light armor");
                    _itemdefense = 20;
                    _armorEquiped = true;
                    _armorweight = 10;
                }
            }
            else if (_armorsubmenuchoice == "2")
            {
                if (80 + _Weaponweight >= _maxweight) // tells game to run this code if your stuff is to heavy
                {
                    Console.WriteLine("This armor is to heavy to be used with this weapon.");
                    Console.WriteLine("switch to a lighter weapon to use the armor or use the lighter armor. ");
                }
                else if (80 + _Weaponweight <= _maxweight)
                {
                    Console.WriteLine("You equiped Heavy armor");
                    _itemdefense = 100;
                    _armorweight = 80;
                    _armorEquiped = true;
                }
            }
            Console.WriteLine("press any key to go back to main inventory");
            Console.ReadKey(); // waits for key to be pressed
            Console.WriteLine();
        }
        public void shop()
        {

            Console.WriteLine("Shop");
            Console.WriteLine("0: exit");
            Console.WriteLine("1: Buy 1 potion cost 30 gold");
            _shopChoice = Console.ReadLine();
            if (_shopChoice == "0")
            {
                return;
            }
            else if (_shopChoice == "1")
            {
                if (_gold <= 30)
                {
                    Console.WriteLine("You need more gold to buy this");

                }

                else if (_gold > 30)
                {
                    Console.WriteLine("you buy 1 potion");
                    _gold = _gold - 30; //takes away 30 gold

                    _potions = _potions + 1;


                }

                // both else if and if are used to check and see if you have the gold to buy the potion

                Console.WriteLine("press any key to go back to main inventory");
                Console.ReadKey(); // waits for key to be pressed
                Console.WriteLine();
            }
        }


        public void usepotions()
        {
            Console.WriteLine("You used 1 potion");
            _maxweight = _maxweight + 30;
            _potions = _potions - 1;
            Console.WriteLine("your max weight is now " + _maxweight);
            Console.WriteLine("");
            Console.WriteLine("press any key to go back to main inventory");
            Console.ReadKey(); // waits for key to be pressed
            Console.WriteLine();
        }

    }
}
