using System;
// - Create a string variable named `typo` and assign the value `Chinchill` to it
// - Write a function called `AppendA()` that gets a string as an input,
//   appends an 'a' character to its end and returns with a string
// - Print the result of `AppendA(typo)`
namespace AppendAfunc
{
    class Program
    {
        static void Main(string[] args)
        {
            string typo = "Chinchill";
            string newTypo = AppendA(typo);
            Console.WriteLine(newTypo);
        }
        public static string AppendA(string input)
        {
            string result = input.Insert(input.Length, "a");
            return result;
        }
    }
}
