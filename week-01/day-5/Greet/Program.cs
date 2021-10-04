using System;

// - Create a string variable named `al` and assign the value `Green Fox` to it
// - Create a function called `Greet()` that greets its input parameter
//     - It prints a greeting message e.g. `Greetings dear Green Fox`
// - Greet `al`
namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "GreenFox";
            Greet(al);        }
        public static void Greet(string who)
        {
            Console.WriteLine($"Greetings dear {who}.");
        }
    }
}
