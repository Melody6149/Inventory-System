using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Inventory
    {

        int damage = 10;
        float gold = 0.00f;
        int defense = 0;
        bool WeaponEquiped = false; // tells game if weapon is equiped
        string armorsubmenuchoice = "";
        /* changed this to be easier to know what this is for
        True means weapon eqiuped
        False means weapon is not equiped
        */
        string Weaponsubmenuchoice = ("0");
        /* 0 means no weapon 
         * 1 means your sword is equiped
         * 2 means your GreatSword
         * 3 means dagger
         * 4 means warhammer
          */

        bool armorEquiped = false;


        int potions = 0;

        string shopChoice = "";

        int Weaponweight = 0;  // for weight system
        int armorweight = 0;  // for weight system
        int maxweight = 100;    //sets max weight for player

        public void Menu()
        {
            String choice = "";

            while (choice != "0")
            {


                Console.WriteLine("Menu");
                Console.WriteLine("");
                Console.WriteLine("Your damage is " + damage + ".");
                Console.WriteLine("You have " + gold + " Gold.");
                Console.WriteLine("Your defense is " + defense + ".");
                Console.WriteLine("You have " + potions + " potions");
                Console.WriteLine("You have a max carry weight of " + maxweight);
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

                    if (potions == 0)
                    {
                        Console.WriteLine("you need potions to use them");
                        Console.ReadKey();
                    }


                    else if (potions > 0)
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

            Weaponsubmenuchoice = Console.ReadLine();
            if (Weaponsubmenuchoice == "b")
            {
                return;
            }
            else if (Weaponsubmenuchoice == "1")
            {
                if (armorweight + 30 >= maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (armorweight + 30 <= maxweight) //checks if weapon weight and armor wieght are under the max weight
                {
                    Console.WriteLine("You picked the sword");
                    damage = 50; // sets damage
                    Weaponweight = 30; //sets weapon weight for use when picking armor
                }


            }
            else if (Weaponsubmenuchoice == "2")
            {
                if (armorweight + 80 >= maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (armorweight + 80 <= maxweight)
                {
                    Console.WriteLine("You picked the GreatSword");
                    damage = 100;
                    Weaponweight = 80;
                }

            }
            else if (Weaponsubmenuchoice == "3")
            {
                if (armorweight + 10 >= maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (armorweight + 10 <= maxweight)
                {
                    Console.WriteLine("You picked the Dagger");
                    damage = 90;
                    Weaponweight = 10;
                }
            }
            else if (Weaponsubmenuchoice == "4")
            {
                if (armorweight + 80 >= maxweight) //checks if weapon weight and armor wieght are above the max weight
                {
                    Console.WriteLine("This weapon is to heavy to use with your current armor");
                }
                else if (armorweight + 80 <= maxweight)
                {
                    Console.WriteLine("You picked the Warhammer");
                    damage = 99;
                    Weaponweight = 80;
                }
            }
            else if (Weaponsubmenuchoice == "0") // making this for unequping a weapon in the same sub menu
            {
                UnequipWeapon(); //uses function for unequip weapon
            }

            Console.WriteLine("");
            Console.WriteLine("You now do " + damage + " damage");
            WeaponEquiped = true; // lets game know a weapon is equiped
            Console.WriteLine("press any key to go back to main inventory");
            Console.ReadKey();
        }


        public void UnequipWeapon()

        {
            if (WeaponEquiped == false)
            //checks if your weapon is rquiped or not equiped using bool. if it is false it runs this line
            {
                Console.WriteLine("You unequiped your imaginary weapon");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Unequiped a weapon");
            damage = 10; // sets damage to 10
            Console.WriteLine("");
            Console.WriteLine("You now do " + damage + " damage");
            WeaponEquiped = false;
            Console.WriteLine();
            Weaponweight = 0;

        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            if (gold < 0) // prevents gold from going below 0
            {
                gold = 0;
            }
            Console.WriteLine("You have " + gold + " gold.");
        }
        public void RemoveGold(float amount)
        {
            Console.WriteLine("You lost " + amount);
            gold -= amount;
            if (gold < 0) // prevents gold from going below 0
            {
                gold = 0;
            }
            Console.WriteLine("You now have " + gold + " gold");
        }
        public void armorsubmenu()
        {
            Console.WriteLine("Armor submenue");
            Console.WriteLine("0:unequip armor");
            Console.WriteLine("1: equip light armor");
            Console.WriteLine("2: Equip Heavy armor");
            // shows player their choices
            armorsubmenuchoice = Console.ReadLine();
            if (armorsubmenuchoice == "0")
            {
                if (armorEquiped == false)
                {
                    Console.WriteLine("You removed your imaginary armor."); // does nothing and sends you back to main inventory menu
                    return;
                }
                Console.WriteLine("you removed your armor");
                defense = 0;
                armorweight = 0;
            }
            else if (armorsubmenuchoice == "1")
            {
                if (10 + Weaponweight > maxweight) // tells game to run this code if your stuff is to heavy
                {
                    Console.WriteLine("This armor is to heavy to be used with this weapon.");
                    Console.WriteLine("switch to a lighter weapon to use the armor ");
                }
                else if (10 + Weaponweight < maxweight)
                {
                    Console.WriteLine("You equiped light armor");
                    defense = 20;
                    armorEquiped = true;
                    armorweight = 10;
                }
            }
            else if (armorsubmenuchoice == "2")
            {
                if (80 + Weaponweight >= maxweight) // tells game to run this code if your stuff is to heavy
                {
                    Console.WriteLine("This armor is to heavy to be used with this weapon.");
                    Console.WriteLine("switch to a lighter weapon to use the armor or use the lighter armor. ");
                }
                else if (80 + Weaponweight <= maxweight)
                {
                    Console.WriteLine("You equiped Heavy armor");
                    defense = 100;
                    armorweight = 80;
                    armorEquiped = true;
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
            shopChoice = Console.ReadLine();
            if (shopChoice == "0")
            {
                return;
            }
            else if (shopChoice == "1")
            {
                if (gold <= 30) 
                {
                    Console.WriteLine("You need more gold to buy this");
                    
                }
                
                else if (gold > 30)
                {
                    Console.WriteLine("you buy 1 potion");
                    gold = gold - 30; //takes away 30 gold
                    
                    potions = potions + 1;

                   
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
            maxweight = maxweight + 30;
            potions = potions - 1;
            Console.WriteLine("your max weight is now " + maxweight);
            Console.WriteLine("");
            Console.WriteLine("press any key to go back to main inventory");
            Console.ReadKey(); // waits for key to be pressed
            Console.WriteLine();
        }

    }
}
