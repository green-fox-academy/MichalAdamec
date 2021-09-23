using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
        }
        public BassGuitar(int numberOfStrings) : base(numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }
        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
