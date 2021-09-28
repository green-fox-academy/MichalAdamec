using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyable
{
    class Bird : Animal, IFlyable
    {
        public Bird()
        { }
        public void Land()
        {
            Console.WriteLine("přistane");
        }
        public void Fly()
        {
            Console.WriteLine("letí");
        }
        public void TakeOff()
        {
            Console.WriteLine("odlepí zadek ze země");
        }
    }
}
