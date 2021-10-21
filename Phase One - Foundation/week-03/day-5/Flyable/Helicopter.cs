using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyable
{
    class Helicopter : Vehicle, IFlyable
    {
       public Helicopter()
        {
            base.totalFuel = 20;
            base.maxSpeed = 50;
            base.distanceMoved = 100;
        }
        public void Land()
        {
            Console.WriteLine("přistane na střechu");
        }
        public void Fly()
        {
            Console.WriteLine("letí");
        }
        public void TakeOff()
        {
            Console.WriteLine("odletame!");
        }
    }
}
