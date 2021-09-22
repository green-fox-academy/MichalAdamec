using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class that represents an aircraft-carrier
//The carrier should be able to store aircrafts

//Each carrier should have a store of ammo represented by a number
//The initial ammo should be given as a constructor parameter
//The carrier also has a health point which is also given as a constructor parameter

//Methods:

//add()
//It should take a new aircraft and add it to its storage

//fill()
//It should fill all the aircrafts with ammo and subtract the taken ammo from the ammo storage
//If there is not enough ammo it should start to fill the aircrafts that are priority first
//It should throw an exception if there is no ammo when this method is called

//fight()
//It should take another carrier as a reference parameter and
//fire all the ammo from the aircrafts to it
//subtract all the damage from the other carrier's health points

//getStatus()
//It should return a string describing its, and all of its aircrafts' statuses in the following format:
//HP: 5000, Aircraft count: 5, Ammo Storage: 2300, Total damage: 2280
//Aircrafts:
//Type F35, Ammo: 12, Base Damage: 50, All Damage: 600
//Type F35, Ammo: 12, Base Damage: 50, All Damage: 600
//Type F35, Ammo: 12, Base Damage: 50, All Damage: 600
//Type F16, Ammo: 8, Base Damage: 30, All Damage: 240
//Type F16, Ammo: 8, Base Damage: 30, All Damage: 240

//If the health points are 0 then it should return: It 's dead Jim :(
namespace AircraftCarrier
{
    class Carrier
    {
        List<Aircraft> aircraftFleet = new List<Aircraft>();
        int health;
        int storeOfAmmo;

        public Carrier()
        {
            aircraftFleet = new List<Aircraft>();
            storeOfAmmo = 2000;
            health = 5000;
        }
        public void Add(Aircraft type)
        {
            aircraftFleet.Add(type);
        }
        public void Fill()
        {
            int neededAmmo = 0;
            foreach (Aircraft aircraft in aircraftFleet)
            {
                neededAmmo += aircraft.GetAmmo();
            }
            
            //if (storeOfAmmo == 0)
            //{ throw new Exception();
                if (storeOfAmmo >= neededAmmo)
                {
                    foreach (Aircraft aircraft in aircraftFleet)
                    {
                        int ammoReturn = aircraft.RefillAmmo(100);

                        storeOfAmmo -= (100 - ammoReturn);
                    }
                }
                else
                {
                    foreach (Aircraft aircraft in aircraftFleet)
                    {
                        if (aircraft.IsPriority(aircraft.GetType()))
                        {
                            storeOfAmmo -= aircraft.GetAmmo();
                        }
                    }
                }
        }
        public void Fight()
        {

        }
        public void GetStatus()
        {

        }
    }
}
