using System;

namespace Bunnies
{
    class Program
    {
        //We have a number of bunnies and each bunny has two big floppy ears.
        //We want to compute the total number of ears across all the bunnies 
        //recursively (without loops or multiplication).
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the number of bunnies...");
            //int bunnies = Int32.Parse(Console.ReadLine());

            int result = NumberOfEars(5);
            Console.WriteLine($"Number of their ears is: {result}");
        }
        static int NumberOfEars(int numOfBunnies)
        {
            int ears = 0;
            if (ears / numOfBunnies == 2)
            {
                return ears;
            }
            else
            {
                //ears = ears + 2;
                return NumberOfEars(ears + 2);
            }
        }
    }
}
