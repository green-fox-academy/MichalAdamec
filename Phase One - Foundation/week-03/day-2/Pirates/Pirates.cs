using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Pirate class. You can add other fields and methods, yet, you must have these methods: X
//DrinkSomeRum() - intoxicates the Pirate by one X
//HowsItGoingMate() -when called, the Pirate replies:X
//if DrinkSomeRun was called less than 4 times:
//"Pour me anudder!"
//else:
//"Arghh, I'ma Pirate. How d'ya d'ink its goin?".Then the pirate passes out and sleeps it off (gets rid of the intoxication).

//If you manage to get this far, then you can try to do the following.
//Brawl(Pirate) -where pirate fights another pirate (if both of them are alive):        X
//there is 1 / 3 chance that this dies, the other dies or they both pass out.           X
//Die() -this kills off the pirate. When a pirate is dead, every method simply results in: he 's dead. X

//And... if you get that far...
//Add a parrot.

namespace Pirate
{
    class Pirate
    {
        string name;
        int intoxication;
        bool alive;

       public Pirate(string name)
        {
            this.name = name;
            intoxication = 0;
            alive = true;
        }
       public void DrinkSomeRum()
        {
            intoxication += 1;
        }
       public void HowsItGoingMate()
        { 
            if(intoxication < 4)
            {
                Console.WriteLine("Pour me anudder!");
            }
            else
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                intoxication = 0;
            }         
        }
        public void Brawl(Pirate pirate)
        {
            if (alive == true)
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 4);
                if (num == 1)
                {
                    pirate.Die();
                }
                else if (num == 2)
                {
                    alive = false;
                }
                else
                {
                    alive = false;
                    pirate.Die();
                    Console.WriteLine("Both pirates died");
                }
            }
            else
                Console.WriteLine("He is already dead!");
        }
        public void Die()
        {
            alive = false;
            Console.WriteLine("he 's dead");
        }
        public void GetPirateStatus()
        {
            Console.WriteLine($"Name: {name}, Intoxication: {intoxication}, Alive: {alive}");
        }
    }
}
