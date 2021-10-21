using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Garden
//is able to hold unlimited amount of flowers and trees
//when watering it should only water those plants that need water with equally divided amount amongst them
//eg. watering with 40 and 4 of them need water then each gets watered with 10

namespace GardenApplication
{
    class TheGarden
    {
        private List<Plant> garden { get; }

        public TheGarden()
        {
            garden = new List<Plant>();
        }
        public void Watering(int water)
        {
            Console.WriteLine($"Watering with:{water}");
            int plantsInNeed = 0;
            foreach (Plant plant in garden)
            {
                if (plant.NeedsWatering(plant.MinimumWater) == "needs water")
                {
                    plantsInNeed += 1;
                }
            }
            int waterDivided = water / plantsInNeed;
            foreach(Plant plant in garden)
            {
                plant.AbsorbWater(waterDivided, plant.Absorbption);
            }
        }
        public void GetStatusOfGarden()
        {
            foreach (Plant plant in garden)
                plant.GetPlantStatus();

        }
        public void AddPlant(Plant plant)
        {
            garden.Add(plant);
        }
    }
}
