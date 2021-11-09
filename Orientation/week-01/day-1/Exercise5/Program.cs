using System;
using System.Linq;

//Write a LINQ Expression to find the frequency of numbers in the following array:
//int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var freq = n.OrderBy(n => n).GroupBy(n => n).ToDictionary(n => n.Key, n => n.Count());

            foreach (var numb in freq)
            Console.Write(numb + ", ");
        }
    }
}
