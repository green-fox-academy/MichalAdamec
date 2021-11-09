using System;
using System.Linq;

//Write a LINQ Expression to convert a char array to a string.

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = {'M','i','c','h','a','l'};
            var name = array.Aggregate("", (result, element) => result + element);      //seed: string.empty  == ""

            Console.WriteLine(name);
        }
    }
}
