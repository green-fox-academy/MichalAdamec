using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 1; a <= 100; a++)
            {
                int Fizz = (a % 3);
                int Buzz = (a % 5);
                int FizzBuzz = (a % 15);
                if (FizzBuzz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (Fizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (Buzz == 0)
                {
                Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(a);
                };
            }
        }
    }
}
