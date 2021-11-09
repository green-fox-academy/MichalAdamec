using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba2.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int Ballance { get; set; }
        public string AnimalType { get; set; }
        public BankAccount(string name, int ballance, string type)
        {
            Name = name;
            Ballance = ballance;
            AnimalType = type;
        }
    }
}
