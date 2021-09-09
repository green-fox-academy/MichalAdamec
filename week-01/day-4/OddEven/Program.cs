using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napište číslo!");
            string number = Console.ReadLine();
            int number1 = Int32.Parse(number);
            if (number1 % 2 == 0)
            {
                Console.WriteLine("Číslo je sudé.");
            }
            else
            {
                Console.WriteLine("Číslo je liché.");
            }

        }
    }
}
