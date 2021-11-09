using System;

// - Create a function called `calculateFactorial()`
//   that returns the factorial of its input
namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            int factorial = CalculateFactorial(n);
            Console.WriteLine($"Factorial of {n} je {factorial}");
        }
        public static int CalculateFactorial(int n)
        {
            int factorial = 1;
            while(n > 1)
            {
                factorial *= n;
                n--;
            }
            return factorial;
        }
    }
}
