using System;
using System.Linq;

//Write a LINQ Expression to get the squared value of the positive numbers from the following array:
//int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var squared = n.Where(n => n > 0).Select(n => n * n).ToList();

            foreach (var numb in squared)
            Console.Write(numb + ", ");
        }
    }
}
