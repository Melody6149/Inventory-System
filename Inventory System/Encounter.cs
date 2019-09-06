using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_System
{
    class Encounter
    {
        private Creature[] _goodmonsters;
        private Creature[] _evilmonsters;


        public Encounter(Creature[] team1, Creature[] team2)
        {
            _goodmonsters = team1;
            _evilmonsters = team2;
        }



        public void Print()
        {

            for (int i = 0; i < _goodmonsters.Length; i++)
            {
                Creature currentMonster = _goodmonsters[i];
                currentMonster.Print();
            }

            for (int i = 0; i < _evilmonsters.Length; i++)
            {
                Creature currentMonster = _evilmonsters[i];
                currentMonster.Print();
            }
        }
        public void beginRound()

        {
            for (int i = 0; i < _goodmonsters.Length; i++)
            {
                Creature currentmonster = _goodmonsters[i];
                currentmonster.Fight(_evilmonsters);
            }
            for (int i = 0; i < _evilmonsters.Length; i++)
            {
                Creature currentmonster = _evilmonsters[i];
                currentmonster.Fight(_goodmonsters);
            }
        }

        public void Start()
        {
            Console.WriteLine("\nEncounter Start!");
            bool stillFighting = true;
            if (_evilmonsters.Length == 0 || _goodmonsters.Length == 0)
            {
                stillFighting = false;
            }
            while (stillFighting)
            {
                //check if team 1 is alive
                bool team1Alive = true;

                for (int i = 0; i < _goodmonsters.Length; i++)
                {
                    Creature currentMonster = _goodmonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        team1Alive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        team1Alive = false;
                    }
                }


                //check if team 2 is alive
                bool team2Alive = true;
                for (int i = 0; i < _evilmonsters.Length; i++)
                {
                    Creature currentMonster = _evilmonsters[i];
                    if (currentMonster.Health > 0)
                    {
                        team2Alive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        team2Alive = false;
                    }
                }

                // if both teams are alive

                if (team1Alive && team2Alive)
                {
                    beginRound();

                    //fight
                }

                else if (!team1Alive || !team2Alive)
                {
                    stillFighting = false;
                    if (team1Alive)
                    {
                        for (int i = 0; i < _goodmonsters.Length; i++ )
                        {
                            Character goodguy = _goodmonsters[i] as Character;

                            Console.WriteLine("YOur team won the encounter.");
                            goodguy.experiance += 1000000;
                            
                        }
                    }
                }

                // if not stop
            }
        }
    }
}
