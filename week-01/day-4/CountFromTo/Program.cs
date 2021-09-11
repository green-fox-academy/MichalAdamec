using System;

namespace CountFromTo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number!");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number!");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (first >= second)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int a = first; a <= second; a++ )
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
