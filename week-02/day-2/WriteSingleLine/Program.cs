using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        // Write a function that is able to manipulate a file
        // By writing your name into it as a single line
        // The file should be named "my-file.txt"
        // In case the program is unable to write the file,
        // It should print the following error message: "Unable to write file: my-file.txt"

        {
            Console.WriteLine("Write your name:");
            string name = Console.ReadLine();
            writeToFile(name);
        }
        static void writeToFile(string a)
        {
            try
            {
                string path = "my-File.txt";
                File.WriteAllText(path, a);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to write file: my-file.txt");
            }


        }
    }
}
