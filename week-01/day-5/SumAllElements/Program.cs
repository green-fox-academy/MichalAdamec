using System;

// - Create an array variable named `numbers`
//   with the following content: `[3, 4, 5, 6, 7]`
// - Print the sum of the elements of `numbers`

namespace SumAllElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 5, 6, 7 };
            int sumOfEl = 0;
            foreach (int numb in numbers)
            {
                sumOfEl += numb;
                Console.WriteLine();
            }
            Console.WriteLine($"sum of all elements: {sumOfEl}");
        }
    }
}
