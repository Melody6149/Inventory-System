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

       /*      string playername = "";
          string playerchoice = "";
            Character Player;
            Console.WriteLine("Enter Your name");
           playername = Console.ReadLine();

            while (playerchoice != "1" && playerchoice != "2")
            {

                //Display menu
                Console.WriteLine("\nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Wizard");
                playerchoice = Console.ReadLine();
            }
            if (playerchoice == "1")
            {
                Player = new Wizzard(playername);
            }
            else if (playerchoice == "2")
            {
                Player = new Knight(playername);
            }
            else
            {
                Player = new Character(playername);
            }
            Player.Print();
            Player.openinventory();
            Player.Print();



            
            Console.ReadKey();
            */

            
            Monster test = new Monster("test 1", 1, 10); //creates monster with the name testmonster with a health of 100 and a damage of 10
            Monster test2 = new Monster("test 2", 1, 10);
            Monster test3 = new Monster("test 3", 50, 10);
            Monster test4 = new Monster("test 4", 99, 10);
            Character player = new Knight("Melody");

            Creature[] goodTeam = {test, test2, player }; //removed test 1 and 2 to check something
            Creature[] evilTeam = { test3, test4 };

            Encounter encounter = new Encounter(goodTeam, evilTeam);
            encounter.Print();


            player.openinventory();
            encounter.Start();

            Console.ReadKey();


            return;
            /* Inventory inventory = new Inventory();
            
             inventory.Menu();*/

           /*string name = "";
            string choice = "";
           // Character Player;
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


                string[] stringarray = new string[3];
                Character[] party = { Player, character2, new Character("character3") };

                Console.ReadKey();    
            }*/
        }
    }
}

