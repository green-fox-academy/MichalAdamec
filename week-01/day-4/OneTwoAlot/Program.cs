using System;

namespace OneTwoAlot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number!");
             
            string number = Console.ReadLine();
            double number2 = Double.Parse(number);
            if (number2 <= 0)
            {
                Console.WriteLine("Not enough");
            }
            else if (number2 == 1)
            {
                Console.WriteLine("one");
            }
            else if (number2 == 2)
            {
                Console.WriteLine("two");
            }
            else
            {
                Console.WriteLine("a lot");

            }
        }
    }
}
