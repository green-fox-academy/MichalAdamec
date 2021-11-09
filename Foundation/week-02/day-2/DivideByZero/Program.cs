using System;
using System.IO;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a number!");
            
            int result = 0;
            try 
            {
                int number = Convert.ToInt32(Console.ReadLine());
                result = 10 / number;
            }
            catch (DivideByZeroException)
            {
                
                Console.WriteLine("fail");
            }
            catch (FormatException)
            {
                Console.WriteLine("fail");
            }

            Console.WriteLine("Výsledek: " + result);
        }
    }
}
