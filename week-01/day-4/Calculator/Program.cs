using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {


       
                Console.WriteLine("Welcome to the Calculator!");

                Console.WriteLine("Please provide the first number:");
                string input = Console.ReadLine();
                double cislo1 = Double.Parse(input);

                Console.WriteLine("Please provide the second number:");
                string input2 = Console.ReadLine();
                double cislo2 = Double.Parse(input2);

                Console.WriteLine("Please provide the operation plus, minus, multiple, divide: ");
                string input3 = Console.ReadLine();

                double result = 0;

                    switch (input3)
                    {
                        case "plus":
                            result = cislo1 + cislo2;
                            break;

                        case "minus":
                            result = cislo1 - cislo2;
                            break;

                        case "multiple":
                            result = cislo1 * cislo2;
                            break;

                        case "divide":
                            result = cislo1 / cislo2;
                            break;

                        default:
                            Console.WriteLine("Invalid operation, please try again.");
                            return;
                    }

                    Console.WriteLine($"Result is {result}");

                Console.WriteLine("Press any-key to continue.");






        }
    }
}