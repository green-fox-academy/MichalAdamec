using System;

//The Pirate Ship
//Create a Ship class.  X
//The Ship stores Pirateinstances in a list as the crew and has one captain who is also a Pirate.
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

//BattleApp
//Create a BattleApp class, where you can fight with ships
//Create 2 ships, fill them with pirates
//Have a battle!

//Armada
//Create an Armada class
//Contains a list of Ship
//Have a armada.War(otherArmada) method where two armada can engage in war
//it should work like merge sort
//first ship from the first armada battles the first one from the other
//the loser ship gets skipped so the next ship comes in play from the loser ship's armada
//it starts a battle with the first (not yet defeated) ship from the other armada
//whichever armada gets to the end of its ships loses the war
//return true if this is the winner

//WarApp
//Create a WarApp class, where you can fight with armadas
//Create 2 armadas, fill them with ships
//Have a war!

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
