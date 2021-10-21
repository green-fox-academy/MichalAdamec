using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApplication
{
    class Plant
    {
        public double AmountOfWater { get; protected set; }
        //public bool NeedsWater { get; protected set; }
        public string Color { get; protected set; }
        public double Absorbption { get; protected set; }
        public int MinimumWater { get; protected set; }
        public Plant(string color)
        {
            Color = color;
            AmountOfWater = 0;
            //NeedsWater = true;
        }
        public string NeedsWatering(int minimumWater)
        {
            if (AmountOfWater < minimumWater)
            {
                return "needs water";
            }
            else
                return "doesnt need water";
        }
        public void AbsorbWater(int amountOfWater, double absorbption)
        {
            double absorbed = (amountOfWater / 100) * absorbption;
            AmountOfWater += absorbed;
        }
        public void GetPlantStatus()
        {
            Console.WriteLine($"The {Color} {this.GetType()} {this.NeedsWatering(MinimumWater)} ({AmountOfWater}).");
        }
    }
}
