using System;
using System.Linq;

// - Create an array variable named `numbers`
//   with the following content: `[3, 4, 5, 6, 7]`
// - Reverse the order of the elements of `numbers`
// - Print the elements of the reversed `numbers`

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 4, 5, 6, 7 };

            //foreach (int numb in numbers.Reverse())
            //{
            //    Console.Write(numb + " ");
            //}

            for (int a = numbers.Length -1; a >= 0; a-- )
            {
                Console.Write(numbers[a]);
            }
        }
    }
}
