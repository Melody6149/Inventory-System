using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Inventory inventory = new Inventory();
            
             inventory.Menu();*/

            string name = "";
            string choice = "";
            Character Player;
            Console.WriteLine("Enter Your name");
            name = Console.ReadLine();

            while (choice != "1" && choice != "2")
            {
                
                //Display menu
                Console.WriteLine("\nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Wizard");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                Player = new Wizzard(name);
            }
            else if (choice == "2")
            {
                Player = new Knight(name);
            }
            else
            {
                Player = new Character(name);
            }
            Player.Print();

            

            Console.ReadKey();
            Console.WriteLine();
            Character character2 = new Character("character2");
            character2.Print();

            while (choice != "0")
            {
                Console.WriteLine("\nWhose inventory");
                
                Console.WriteLine("1: " + Player.name());
                Console.WriteLine("2: " + character2.name());
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Player.Print();
                    Console.WriteLine(Player.name());
                    Player.openinventory();
                    
                }
                else if (choice == "2")
                {
                    character2.Print();
                    Console.WriteLine(character2.name());
                    character2.openinventory();
                }
            }




            Player.experiance = 30;
            Player.experiance = Player.experiance + 50;
            Player.experiance++;
            Player.experiance++;
            Player.experiance++;
            Player.experiance++;
            Player.experiance += 40;
            int[] testArray = new int[4];
            testArray[0] = 1;
            testArray[1] = 4;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };
            string[] stringarray = new string[3];
            Character[] party = { Player, character2, new Character("character3") };

            Console.ReadKey();
        }
    }
}
