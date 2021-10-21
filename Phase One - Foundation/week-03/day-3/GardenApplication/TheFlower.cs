using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Flower
//needs water if its current water amount is less than 5
//when watered the flower can only absorb 75% of the water
//eg. watering with 10 the flower's amount of water should only increase by 7.5

namespace GardenApplication
{
    class TheFlower : Plant
    {
        public TheFlower(string color) : base(color)
        {
            Absorbption = 75;
            MinimumWater = 5;
        }
    }
}
