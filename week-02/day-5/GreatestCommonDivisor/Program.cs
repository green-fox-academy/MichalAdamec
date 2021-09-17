using System;

namespace GreatestCommonDivisor
{
    //Find the greatest common divisor of two numbers using recursion
    class Program
    {
        static void Main(string[] args)
        {
            int result = CommonDivisor(14, 21);
            Console.WriteLine(result);
        }
        static int CommonDivisor(int numb1, int numb2)
        {
            int divisor = 1;
            if ((numb1 % divisor == 0) && (numb2 % divisor == 0))
            {
                return divisor;
            }
            else
            {
                return CommonDivisor(numb1 / divisor + 1, numb2 / divisor + 1);
            }
        }
    }
}
