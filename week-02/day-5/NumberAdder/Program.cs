using System;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
        {
            int result = NumberAdder(5);

            Console.WriteLine(result);
        }
        static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return NumberAdder(n-1) + n;
            }

        }
    }
}
