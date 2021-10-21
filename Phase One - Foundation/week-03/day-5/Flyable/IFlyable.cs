using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyable
{
    interface IFlyable
    {
        public void Land();
        public void Fly();
        public void TakeOff();
    }
}
