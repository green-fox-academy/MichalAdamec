using System;
using System.Linq;

//Write a LINQ Expression to get the even numbers from the following array:
//int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var evenNumbers = n.Where(e => e % 2 == 0).ToList();
            foreach (var numb in evenNumbers)
                Console.Write(numb + ", ");
        }
    }
}
