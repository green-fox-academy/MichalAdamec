using System;
using System.IO;

namespace CountLIne
{
    class Program
    {
        static void Main(string[] args)
        // Write a function that takes a filename as string,
        // then returns the number of lines the file contains.
        // It should return zero if it can't open the file, and
        // should not raise any error.
        {
            string path = "TextFile.txt";
            Console.WriteLine(Counting(path));
        }
        static int Counting(string a)
        {
            int allLines = 0;
            try
            {
                allLines = File.ReadAllLines(a).Length;
            }
            catch (FileNotFoundException)
            {
                allLines = 0;
            }
            return allLines;
        }
    }
}
