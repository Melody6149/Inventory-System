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

            Character Player = new Character("Melody");
            Player.Print();

            Console.ReadKey();
            Console.WriteLine();
            Character character2 = new Character("character2");
            character2.Print();

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
