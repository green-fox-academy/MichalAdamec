using System;
using System.IO;

// Create a method that decrypts reversed-lines.txt

namespace ReversedLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "reversed-lines.txt";
            Decryption(input);
        }
        public static void Decryption(string input)
        {
            string[] array = File.ReadAllLines(input);
            for (int a = 0; a < array.Length; a++)
            {
                string line = array[a];
                for (int b = line.Length - 1; b >= 0; b--)
                {
                    Console.Write(line[b]);
                }
                Console.WriteLine();
            }

        }
    }
}
