using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = { 3, 4, 5, 6, 7 };

            for (int x = 0; x <= 4; x++)
            {
                int y = numbers[x];
                numbers[x] = y * 2;
                Console.WriteLine(numbers[x]);

            }


            Console.ReadLine();
        }
    }
}
