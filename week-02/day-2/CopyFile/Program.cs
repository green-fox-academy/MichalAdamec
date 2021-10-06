using System;
using System.IO;

// Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies the file)
// It should take the filenames as parameters
// It should return a boolean that shows if the copy was successful
namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename1 = "Text1.txt";
            string filename2 = "Text2.txt";
            Console.WriteLine($"Copy was succeful: { CopyFile(filename1, filename2)}");
        }
        public static bool CopyFile(string filename1, string filename2)
        {
            string text = File.ReadAllText(filename1);
            File.WriteAllText(filename2, text);
            string textCopied = File.ReadAllText(filename2);

            bool done;
            if (text == textCopied)
            {
                done = true;
            }
            else
            done = false;

            return done;
        }
    }
}
