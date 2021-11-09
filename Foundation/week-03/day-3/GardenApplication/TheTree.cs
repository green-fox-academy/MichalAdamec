using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Tree
//needs water if its current water amount is less than 10
//when watered the tree can only absorb the 40% of the water
//eg. watering with 10 the tree's amount of water should only increase by 4

namespace GardenApplication
{
    class TheTree : Plant
    {
        public TheTree(string color) : base(color)
        {
            Absorbption = 40;
            MinimumWater = 10;
        }
        
    }
}
