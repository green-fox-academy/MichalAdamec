using System.Collections.Generic;
using System;
// - You have the `Thing` class
// - You have the `Fleet` class
// - You have the `FleetOfThings` class with a `Main()` method
// - Download those, use those
// - In the Main() method create a fleet

// Create a fleet (list) of things to have this output:
// 1. [ ] Get milk
// 2. [ ] Remove the obstacles
// 3. [x] Stand up
// 4. [x] Eat lunch
// Hint: You have to create a Print method also

namespace FleetOfThings
{
    public class FleetOfThings
    {
        public static void Main(string[] args)
        {
            //vytvoření  instance typu Fleet (variable type) s názvem "fleet"
            var fleet = new Fleet();
          
             
            //vytvoření instance typu Položka s názvem "task 1 - 4"
            Polozka task1 = new Polozka("[Get milk");
            Polozka task2 = new Polozka("Remove the obstacles");
            Polozka task3 = new Polozka("Stand up");
            Polozka task4 = new Polozka("Eat lunch");

            fleet.Add(task1);
            fleet.Add(task2);
            fleet.Add(task3);
            fleet.Add(task4);

            task3.Complete();
            task4.Complete();

            fleet.Print();

        }
    }
}