using System;
using System.Linq;

//Write a LINQ Expression to find the frequency of characters in a given string.

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Kobyla ma maly bok.";

            var freq = word.OrderBy(a => a).GroupBy(a => a).ToDictionary(a => a.Key, a => a.Count());

            foreach(var letter in freq)
            Console.WriteLine(letter);
        }
    }
}
