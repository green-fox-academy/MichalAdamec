using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Fox
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public string Color { get; protected set; }
        public Fox(string name, string type, string color)
        {
            Name = name;
            Type = type;
            Color = color;
        }

    }
}
