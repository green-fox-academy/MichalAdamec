using System;

namespace SumDigit
{
    class Program
    {
        //Given a non-negative integer n, return the sum of its digits recursively(without loops).
        static void Main(string[] args)
        {
            int result = DigitsSum(12345);
            Console.WriteLine(result);
        }
        static int DigitsSum(int numb)
        {

            if (numb < 10)
            {
                return numb;
            }
            else
            {
                int digit = numb % 10;
                int next = numb / 10;
                return DigitsSum(next) + digit;
            }


        }
    }
}
