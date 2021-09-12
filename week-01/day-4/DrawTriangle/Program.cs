using System;

namespace DrawTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            string symbol = "*";

            for (int a = 1; a <= number; a++)
            {
                int b = 0;
                for (b = 0; b < a; b++)
                {
                    Console.Write(a + " ");
                }
                Console.WriteLine();              
            }
            Console.WriteLine();

            for (int a = 1; a <= number; a++)
            {
                int b = 0;
                for (b = 0; b < a; b++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
