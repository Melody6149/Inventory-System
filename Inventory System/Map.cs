using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inventory_System
{
    class Map
    {
        private int _currentLocation = 0; //Id of the current scene
        private Scene[] _sceneList; //List all of the scenese on the map

        public Map(int StartingSceneID, Scene[] scenes)
        {
            _currentLocation = StartingSceneID;
            _sceneList = scenes;
        }
        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                if (value >= 0 && value < _sceneList.Length)
                {
                    //Change to the new scene
                    _currentLocation = value;
                }
                else
                {
                    Console.WriteLine("\nIvalid scene ID");
                }
            }
        }

        public void PrintCurrentScene()
        {
            //If the current scene ID is within rage
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDescription());
            }
            else
            {
                Console.WriteLine("\nIvalid scene ID");
            }
        }


        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                //lets player know where they are
                PrintCurrentScene();
                //Print the menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0:Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2 search");
                Console.WriteLine("3: Save");
                Console.WriteLine("4: Load");
                // Gets the players choice
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    Travel();
                }
                else if (choice == "2")
                {
                    Search();
                }
                else if (choice == "3")
                {
                    Save("save.txt");
                }
                else if (choice == "4")
                {
                    Load("save.txt");
                }
            }

        }
        public void Travel()
        {
            int destination = -1;

            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                destination = _sceneList[_currentLocation].chooseexit();
            }
            if (destination >= 0 && destination < _sceneList.Length)
            {
                CurrentSceneID = destination;

            }
            else
            {
                Console.WriteLine("There is nothing in that direction");
            }

        }

        public void Save(string path)
        {
            //Create a writer for the file at our path
            StreamWriter writer = File.CreateText(path);
            //Write to it the same way we write
            writer.WriteLine(CurrentSceneID);

            //ckise it
            writer.Close();

        }
        public void Load(string path)
        {
            if (File.Exists(path))
            {
                //Create a reader object for the file at our path
                StreamReader reader = File.OpenText(path);
                // Write to it the same way we read from the console
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                //close it
                reader.Close();
            }
            else
            {
                Console.WriteLine("THere is no save file to load from.");
            }
        }


        public void Search()
        {
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                Console.WriteLine(_sceneList[_currentLocation].GetHIdden());
            }
        }

    }
}
