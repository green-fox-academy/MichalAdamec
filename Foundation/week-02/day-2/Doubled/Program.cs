using System;
using System.IO;

// Create a method that decrypts the duplicated-chars.txt

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "duplicated-chars.txt";
            string output = "resolved.txt";
            Decryption(input, output);
        }
        public static void Decryption(string input, string output)
        {
            string original = File.ReadAllText(input);          //přečte file
            string resolved = "";
            char letter = ' ';

            for (int a = 0; a < original.Length; a += 2)
            {
                letter = original[a];
                if (letter == '\r')
                    letter = '\n';
                resolved += letter;
            }

            Console.WriteLine(original);
            File.WriteAllText(output, resolved);
            Console.WriteLine();
            Console.WriteLine($"Decrypted text: \n\n{resolved}");
        }
    }
}
