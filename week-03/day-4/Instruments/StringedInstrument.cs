using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Next, we add another abstract class, StringedInstrument which inherit from Instrument. It
//introduces numberOfStrings and
//Sound() method what's implementation is yet unknown
//but with the help of the Sound() the Play() method is fully implementable

namespace Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numberOfStrings;

        protected StringedInstrument()
        {
        }

        protected StringedInstrument(int numberOfStrings)
        {
            this.numberOfStrings = numberOfStrings;
        }

        abstract public void Sound();

        public override void Play()
        {
             Sound();
        }
    }
}
