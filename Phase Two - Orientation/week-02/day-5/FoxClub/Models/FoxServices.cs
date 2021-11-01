using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxServices
    {
        public List<Fox> Foxes { get; set; }
        public List<string> Food { get; set; } = new List<string> { "pizza", "raw eggs", "dandelion salad" };
        public List<string> Drink { get; set; } = new List<string> { "wine", "lemonade", "milk" };
        public List<string> TricksList { get; set; } = new List<string> { "code in Java", "HTML", "SQL" };


        public FoxServices()
        {
            Foxes = new List<Fox>();
        }
        public void AddFood(string food)
        { Food.Add(food); }
        public void AddDrink(string drink)
        { Drink.Add(drink); }
        public void AddTrick(string trick)
        { TricksList.Add(trick); }
        public void AddFox(Fox fox)
        { Foxes.Add(fox); }
        public Fox GetFox(string name)
        {
            return Foxes.FirstOrDefault(x => x.Name == name);
        }
    } 

}
