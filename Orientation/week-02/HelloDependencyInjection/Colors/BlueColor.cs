using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloDependencyInjection
{
    public class BlueColor : IColor
    {
        public void PrintColor()
        {
            Console.WriteLine("It is BLUE in color...");
        }
    }
}
