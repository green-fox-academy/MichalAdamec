using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDependencyInjection
{
    public class GreenColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is GREEN in color...");
        }
    }
}
