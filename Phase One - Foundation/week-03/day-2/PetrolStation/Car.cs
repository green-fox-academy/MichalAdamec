using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Car
    {
        private int GasAmount = 0;
        private int Capacity = 100;

        public Car()
        {          
        }
        public int GetCapacity()
        {
            return Capacity;
        }
        public int GetGas()
        {
            return GasAmount;
        }
        public void Refill()
        {
            if (GasAmount == 0)
            {
                GasAmount += 100;
            }
            else
            {
                GasAmount = 100;
            }
        }
        public void PrintGas()
        {
            Console.WriteLine($"The gas amount is: {GasAmount}");
        }
    }
}
