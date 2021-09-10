using System;

namespace CompareLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArrayOfNumbers = { 1, 2, 3 };
            
            int[] secondArrayOfNumbers = { 4, 5 };
           

            string second = "SecondArrayOfNumbers has more elements than FirstArrayOfNumbers";
            string first = "FirstArrayOfNumbers is the longer one";

            if (firstArrayOfNumbers.Length < secondArrayOfNumbers.Length)
            {
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(first);
               
            }
        }
    }
}
