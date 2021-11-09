using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebApp.Models
{
    public class ListOfItems
    {
        public List<Item> ListFromModel { get; set; } = new List<Item>();
        public void Add(Item item)
        {
            ListFromModel.Add(item);
        }
    }
}
