using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        string sound = "Screech";
        public Violin()
        {
            numberOfStrings = 4;
            base.name = "Violin";
        }
        public Violin(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
            base.name = "Violin";
        }
        public override void Sound()
        {
            Console.WriteLine($"{name}, a {numberOfStrings} stringed instrument that {sound}");
        }
    }
}
