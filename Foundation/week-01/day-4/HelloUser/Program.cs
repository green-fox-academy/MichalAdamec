using System;

namespace HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("Hello, " + userName);
        }
    }
}
