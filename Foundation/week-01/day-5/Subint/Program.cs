using System;

//  Create a function that takes a number and an array of integers as parameters
//  It returns the indices of the integers of the array which contain the given number
//  or returns an empty array (if the number is not part of any of the integers in the array)
//  Example:
//Console.WriteLine(FindMatchingIndexes(1, new int[] { 1, 11, 34, 52, 61 }));
//  should print: `[0, 1, 4]`
//Console.WriteLine(FindMatchingIndexes(9, new int[] { 1, 11, 34, 52, 61 }));
//  should print: '[]'

namespace Subint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int[] array = new int[] { 4, 2, 14, 25, 13, 29, 8, 45, 42, 48, 81 };

            FindMatchingIndexes(n, array);
        }
        public static void FindMatchingIndexes(int input, int[] array)
        {
            int[] result = new int[array.Length];

            Console.Write("[");
            for (int a = 0; a < array.Length; a++)
            {
                if ((array[a] % 10) == input || (array[a] / 10) == input)
                {
                    result[a] = a;
                }
                else
                    result[a] = 99;
            }
            foreach (int index in result)
            {
                if (index != 99)
                {
                    Console.Write(index + " ");
                }

            }
            Console.Write("]");
        }
    }
}
