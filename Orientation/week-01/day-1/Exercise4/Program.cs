using System;
using System.Linq;

//Write a LINQ Expression to find which number squared value is more then 20 from the following array:
//int[] n = new[] { 3, 9, 2, 8, 6, 5 };

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            var whichOnes = n.Where(n => (n * n) > 20).ToList();

            foreach (var numb in whichOnes)
            Console.Write(numb + ", ");
        }
    }
}
