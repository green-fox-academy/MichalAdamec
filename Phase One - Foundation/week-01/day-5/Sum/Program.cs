using System;

// Write a function called `sum()` that returns the sum of numbers from zero to the given parameter
namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int sum = Sum(n);
            Console.WriteLine($"Sum of all numbers from 0 to {n} is {sum}");
        }
        public static int Sum(int n)
        {
            int sum = 0;
            for(int a = n; a >= 0; a--)
            {
                sum += a;
            }
            return sum;
        }
    }
}
