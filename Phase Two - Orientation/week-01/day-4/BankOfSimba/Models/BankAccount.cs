using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Ballance { get; set; }
        public string AnimalType { get; set; }
        public BankAccount(string name, int ballance, string animalType)
        {
            Name = name;
            Ballance = ballance;
            AnimalType = animalType;
        }
    }
}
