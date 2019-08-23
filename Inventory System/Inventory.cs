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
        int WeaponEquiped = 0;
        /* 0 means no weapon 
         * 1 means your sword is equiped
         * 2 means your GreatSword
         * 3 means dagger
         * 4 means warhammer
          I can use int to add more weapons later
          */
        string Weaponchoice =(0);
        public void Menu()
        {
            String choice = "";

            while (choice != "0")
            {

                Console.WriteLine("Menu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: Give Gold");
                Console.WriteLine("4: Remove Gold");


                choice = Console.ReadLine();
                Console.WriteLine("");

                // check input
                if (choice == "1")
                {
                    EquipWeapon();
                }
                else if (choice == "2")
                {
                    UnequipWeapon();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("How much gold");
                    float Goldamount = Convert.ToSingle(Console.ReadLine());
                    AddGold(Goldamount);
                }
                else if (choice == "4")
                {
                    Console.WriteLine("How much gold");
                    float Goldamount = Convert.ToSingle(Console.ReadLine());
                    RemoveGold(Goldamount);
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

            Console.WriteLine ("What do you want to pick")
            Console.WriteLine("1: Sword");
            Console.WriteLine("2: GreatSword");
            Console.WriteLine("3: Dagger");
            Console.WriteLine("4: Warhammer ");
            Weaponchoice = Console.ReadLine();


            
            Console.WriteLine("");
            Console.WriteLine("You now do " + damage + " damage");
            WeaponEquiped = 1;
            Console.WriteLine();
        }


        public void UnequipWeapon()

        {
            if (WeaponEquiped == 0)
            //checks if your weapon is rquiped or not equiped
            {
                Console.WriteLine("You need to equip a weapon to unequip a weapon");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Unequiped a weapon");
            damage = 10; // sets damage to 10
            Console.WriteLine("");
            Console.WriteLine("You now do " + damage + " damage");
            WeaponEquiped = 0;
            Console.WriteLine();
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " gold!");
            gold += amount;
            Console.WriteLine("You have " + gold + " gold.");
        }
        public void RemoveGold(float amount)
        {
            Console.WriteLine("You lost " + amount);
            gold -= amount;
            if (gold < 0)
            {
                gold = 0;
            }
            Console.WriteLine("You now have " + gold + " gold");
        }

    }
}
