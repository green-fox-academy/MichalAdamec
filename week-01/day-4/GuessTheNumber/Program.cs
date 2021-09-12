using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the number!");
            double guess = Convert.ToInt32(Console.ReadLine());
            double guessednumb = 125;

            while (guess != guessednumb)
            {
                Console.WriteLine("Guess the number again!");
                Console.WriteLine();
                double guessagain = Convert.ToInt32(Console.ReadLine());
                if (guessagain < guessednumb)
                {
                    Console.WriteLine("The stored number is higher.");
                }
                else if (guessagain > guessednumb)
                {
                    Console.WriteLine("The stored number is lower.");
                }
            }
            Console.WriteLine("You found the number:" + guessednumb);
        }
    }
}
