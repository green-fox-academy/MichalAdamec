using System;
using System.Linq;

//Write a LINQ Expression to find the uppercase characters in a string.

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "BlAbLALablE";

            var upper = word.Where(char.IsUpper).ToArray();

            foreach (var letter in upper)
            Console.Write(letter + ", ");
        }
    }
}
