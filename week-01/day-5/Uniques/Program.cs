using System;

//  Create a method that takes an array of integers as a parameter
//  and returns an array of integers where every integer is unique (occurs only once)
//  Example
//Console.WriteLine(FindUniqueItems(new[] { 1, 11, 34, 11, 52, 61, 1, 34 }));
//  should print: `[1, 11, 34, 52, 61]`

namespace Uniques
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 11, 34, 11, 52, 61, 1, 34 };       //[1, 11, 34, 52, 61]
            int[] uniqueArray = FindUniqueItems(array);
            foreach (int numb in uniqueArray)
            {
                Console.Write(numb + " " );
            }
        }
        public static int[] FindUniqueItems(int[] array)
        {
            int[] uniqueArray = new int[array.Length];
            for(int a = 0; a < array.Length; a++)
            {
                for(int b = 1; b < array.Length; b++)
                {
                    if (array[a] == array[b])
                    {
                        uniqueArray[a] = array[a];
                    }
                    else
                        uniqueArray[a] = 0;
                }
            }
            return uniqueArray;
        }

    }
}
