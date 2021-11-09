using System;

namespace GreatestCommonDivisor
{
    //Find the greatest common divisor of two numbers using recursion
    class Program
    {
        static void Main(string[] args)
        {
            int result = CommonDivisor(125, 90);
            Console.WriteLine(result);
        }
        static int CommonDivisor(int a, int b)
        {
            int reminder = b;
            if (reminder == 0)
            {
                return a;
            }
            else
            {
                reminder = a % b;
                return CommonDivisor(b, reminder);
            }
            //Euclidean Algorithm
            //GCD of    a, b  ->   b, a % b = b, c  ->  b, c = new a, b
            //      new a, b  ->   b, a % b = b, c  ->  b, c = new a, b
            //       .....until (b, 0) c = 0  ->   b = GCD
        }
    }
}
