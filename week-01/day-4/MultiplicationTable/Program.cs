using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number for multiplication!");

            int number = Convert.ToInt32(Console.ReadLine());

            for (int a = 1; a <= 100; a++)
            {
                int multiple = (a * number);
                Console.WriteLine(a + "x" + number + " = " + multiple);
            }
        }
    }
}
