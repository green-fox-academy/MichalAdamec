using System;
using System.Linq;

//Write a LINQ Expression to get the average value of the odd numbers from the following array:
//int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var oddAverage = n.Where(n => n % 2 != 0).Average();

            Console.WriteLine(oddAverage);
        }
    }
}
