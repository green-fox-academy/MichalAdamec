using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            this.numberOfStrings = 4;
        }
        public Violin(int numberOfStrings) : base(numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }
        public override string Sound()
        {
            return "Screech";
        }
    }
}
