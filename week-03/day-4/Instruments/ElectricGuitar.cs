using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
        }
        public ElectricGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}
