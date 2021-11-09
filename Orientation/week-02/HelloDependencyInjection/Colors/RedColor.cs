using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDependencyInjection
{
    public class RedColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is RED in color...");
        }
    }
}
