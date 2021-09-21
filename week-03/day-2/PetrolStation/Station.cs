using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolStation
{
    class Station
    {
        private int GasAmount = 500;

        public Station()
        {

        }
        public void Refill(Car car)
        {
            GasAmount -= car.GetCapacity();
            car.Refill();
        }
    }
}
