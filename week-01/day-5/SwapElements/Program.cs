using System;

// - Create an array variable named `orders`
//   with the following content: `["first", "second", "third"]`
// - Swap the first and the third element of `orders`
namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] orders = new string[]
            {"first", "second", "third"};

            (orders[0], orders[2]) = (orders[2], orders[0]);
            foreach (string ord in orders)
            {
                Console.Write($"{ord}  ");
                Console.WriteLine();
            }
        }
    }
}
