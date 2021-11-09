using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;

namespace FoxClub.ViewModels
{
    public class FoxNutritionsTricks
    {
        public List<string> Food { get; set; } = new List<string> { "pizza", "raw eggs", "dandelion salad" };
        public List<string> Drink { get; set; } = new List<string> { "wine", "lemonade", "milk" };
        public List<string> TricksList { get; set; } = new List<string> { "code in Java", "HTML", "SQL" };
        public FoxNutritionsTricks(Fox fox)
        {

        }
    }
}
