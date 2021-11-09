using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldRESTApp.Models
{
    public class Greeting
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public Greeting(string name)
        {
            Content = name;
        }
        public Greeting()
        {
        }
    }
}
