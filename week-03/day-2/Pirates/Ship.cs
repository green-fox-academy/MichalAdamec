using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Pirate Ship
//Create a Ship class.  X
//The Ship stores Pirate instances in a list as the crew and has one captain who is also a Pirate.  X
//When a ship is created it doesn't have a crew or a captain.
//The ship can be filled with pirates and a captain via FillShip() method.
//fills the ship with a captain and a random (maximum 113) number of pirates
//Ships should be represented in a nice way on command line including information about
//rum consumed by the captain and its state (dead or alive)
//number of alive pirates in the crew
//Ships should have a method to battle other ships: ship.Battle(otherShip)
//should return true if the actual ship(this) wins
//the ship having higher calculated score wins
//calculated score: Number of alive pirates in the crew - Number of consumed rum by the captain
//The loser crew has a random number of losses (deaths).
//The winning captain and crew has a party: everyone drinks a random number of rum :)

namespace Pirate
{
    class Ship
    {
        List<Pirate> crew = new List<Pirate>();
        Pirate captain = new Pirate("Captain");
        Pirate pirate = new Pirate("another pirate");
        public Ship()
        { }
        public void FillShip()
        {
            crew.Add(captain);              //přidá kapitána

            Random rnd = new Random();
            int numOfPirates = rnd.Next(1, 114);        //přidá náhodný počet pirátů mezi 1-113
            for (int a = 1; a <= numOfPirates; a++)
            {
                crew.Add(pirate);
            }

        }


    }
}
