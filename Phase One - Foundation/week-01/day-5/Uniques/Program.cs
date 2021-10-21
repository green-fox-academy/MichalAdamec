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
                Console.Write(numb + " ");
            }
        }
        public static int[] FindUniqueItems(int[] array)
        {       
            bool[] isUniq = new bool[array.Length];         //array of bools, false = duplicit , true = unique

            for (int c = 0; c < array.Length; c++)          //fills bool array with true values
                isUniq[c] = true;

            for (int a = 0; a < array.Length; a++)          //searching for duplicit values
            {
                for (int b = a +1; b < array.Length; b++)
                {
                    if (array[a] == array[b])
                    {
                        isUniq[b] = false;
                    }
                }
            }
            int count = 0;
            foreach (bool isTrue in isUniq)                 //finding length for new array of unique numbers
            {
                if (isTrue == true)
                    count += 1;
            }

            int[] uniqueNumbers = new int[count];           //initializing unique numbers array
            int next = 0;                                   //index for new (smaller) array
            for (int e = 0; e < array.Length; e++)          //writing unique values into new array
            {
                if (isUniq[e] == true)
                {
                    uniqueNumbers[next] = array[e];
                    next += 1;
                }
            }
            return uniqueNumbers;
        }

    }
}
