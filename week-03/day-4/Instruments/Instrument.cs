using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We start with a base, abstract class Instrument.
//it reserves(e.g. protected) the name of the instrument
//it should provide a Play() method.

//Next, we add another abstract class, StringedInstrument which inherit from Instrument. It
//introduces numberOfStrings and
//Sound() method what's implementation is yet unknown
//but with the help of the Sound() the Play() method is fully implementable

//StringedInstrument has 3 descendants, namely:
//Electric Guitar(6 strings, "Twang")
//Bass Guitar(4 strings, "Duum-duum-duum")
//Violin(4 strings, "Screech")
namespace Instruments
{
    abstract class Instrument
    {
        protected string name;

        abstract public void Play();
      
    }
}
