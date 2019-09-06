using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    //create a constructor to set the values of all member variables
    //Create functions to return the values of all private member variables
    //Create a function called "Choose exit" that will display menu that allows the player to choose which direction to travel
    //The function should retrun an int being a value that represents the direction the player wishes to travel
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;
        private Creature[] _enemies;
        private bool _clear = false; // tells game if room is cleared or not


        public Scene(string name, int northID, int southID, int eastID, int westID, string description, Creature[] enemies)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _description = description;
            _hidden = "nothing was found";
            _enemies = enemies;
            if (_enemies.Length == 0)
            {
                _clear = true; 
            }

        }
        public Scene(string name, int northID, int southID, int eastID, int westID, string description, string hidden, Creature[] enemies)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _description = description;
            _hidden = hidden;
            _enemies = enemies;

            if (_enemies.Length == 0)
            {
                _clear = true;
            }
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }

        public Creature[] GetEnemies()
        {
            return _enemies;
        }

        public bool GetClear()
        {
            return _clear;
        }

        public int chooseexit()
        {
            string choice = "";
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W")
            {


                Console.WriteLine("Chose a direction N/S/E/W");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
                if (choice == "N")

                {
                    return _north;
                }
                else if (choice == "S")
                {
                    return _south;
                }
                else if (choice == "E")
                {
                    return _east;
                }
                else if (choice == "W")
                {
                    return _west;
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }
        public string GetHIdden()
        {
            return _hidden;
            
        }
    }

}
