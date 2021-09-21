using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Polozka> seznam;

        public Fleet()
        {
            seznam = new List<Polozka>();
        }

        public void Add(Polozka thing) //přidá položku do seznamu <thing>
        {
            seznam.Add(thing);
        }
        public void Print()
        {
            for (int a = 0; a < seznam.Count; a++)
            {
                Console.Write($"{a + 1}. ");
                seznam[a].Print();               
            }
        }
    }
}