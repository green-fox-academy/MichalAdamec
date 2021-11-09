using System;
using System.Linq;
using System.IO;

//Find a random Wikipedia article and copy the contents to a txt file.      X
//Create a single LINQ expression which reads all text from this file,
//and prints the 100 most common words in descending order.
//Keep in mind that the text contains punctuation characters which should be ignored.
//The result should be something like this:

//the: 131
//of: 74
//and: 48
//to: 45
//a: 43
//in: 43
//was: 30
//as: 21
//German: 18
//for: 16
//his: 15
//by: 13
//he: 11
//that: 11...

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { ',', '.', '/', '!', '@', '#', '$', '%', '^', '&', '*', ';', '_', '(', ')', ':', '|', '[', ']','"'};

            string source = "Wiky.txt";
            var article = File.ReadAllText(source).Split(chars).GroupBy(x => x);

            foreach (var word in article)
            Console.Write(word);
            Console.WriteLine();
        }
    }
}
