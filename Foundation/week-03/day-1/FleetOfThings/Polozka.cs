using System;

namespace FleetOfThings
{
    public class Polozka
    {
        private string Name;
        private bool Completed;

        public Polozka(string name)
        {
            this.Name = name;
        }

        public void Complete()
        {
            this.Completed = true;
        }
        public void Print ()
        {
            if (Completed == true)
            {
                Console.WriteLine($"položka: [X] {Name}");
            }
            else
            {
                Console.WriteLine($"položka: [ ] {Name}");
            }
        }

    }
}