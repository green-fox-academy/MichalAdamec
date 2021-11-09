using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class ElectricGuitar : StringedInstrument
    {
        string sound = "Twang";
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            base.name = "ElectricGuitar";
        }
        public ElectricGuitar(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
            base.name = "ElectricGuitar";
        }

        public override void Sound()
        {
            //return $"{name}, a {numberOfStrings} stringed instrument that {sound}";

            Console.WriteLine( $"{name}, a {numberOfStrings} stringed instrument that {sound}");
        }
    }
}
