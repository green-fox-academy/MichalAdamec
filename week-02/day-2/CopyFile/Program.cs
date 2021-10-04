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
        }
        public bool CopyFile(string filename1, string filename2)
        {
            filename1 = "Text1.txt";
            filename2 = "Text2.txt";

            string text = File.ReadAllText(filename1);
            File.WriteAllText(filename2, text);

            bool done;
            if(filename2 == filename1)
            {
                return done = true;
            }
            return done = false;

            Console.WriteLine(done);


        }
    }
}
