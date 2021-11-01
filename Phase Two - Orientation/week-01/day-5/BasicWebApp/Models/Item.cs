using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebApp.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public Item(string name, string description, int price, int quantity)
        {
            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
        public Item()
        {
        }
    }
}
