using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public List<string> Tricks { get; set; } = new List<string>();
        public string Name { get; set; } = "Mr.Fox";
        public string Food { get; set; } = "anything";
        public string Drink { get; set; } = "doesn't have favourite drink yet";
        public Fox(string name)
        {
            Name = name;
        }
    }
}
