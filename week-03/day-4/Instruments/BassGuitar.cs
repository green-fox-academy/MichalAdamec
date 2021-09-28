using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class BassGuitar : StringedInstrument
    {
        string sound = "Duum-duum-duum";

        public BassGuitar()
        {
            numberOfStrings = 4;
            base.name = "BassGuitar";
        }
        public BassGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
            base.name = "BassGuitar";

        }
        public override void Sound()
        {
            Console.WriteLine($"{name}, a {numberOfStrings} stringed instrument that {sound}");
        }
    }
}
