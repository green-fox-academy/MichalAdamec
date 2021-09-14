using System;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileContent = File.ReadAllText("my-file.txt");
                Console.WriteLine(fileContent);
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }
        }
    }
}
