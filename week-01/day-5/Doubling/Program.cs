using System;

// - Create an integer variable named `baseNumber` and assign the value `123` to it
// - Create a function called `DoubleNumber()` that doubles it's input parameter
//   and returns the doubled value
// - Print the result of `DoubleNumber(baseNumber)`
namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNumber = 123;
            int doubled = DoubleNumber(baseNumber);
            Console.WriteLine($"The double of the number {baseNumber} is {doubled}");
        }
        public static int DoubleNumber(int baseNumber)
        {
            int result = 2 * baseNumber;
            return result;
        }
    }
}
