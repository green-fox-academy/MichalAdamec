using System;
using System.IO;
using System.Collections.Generic;

namespace WriteMultipleLines
{
    class Program
    {// Create a function that takes 3 parameters: a path, a word and a number
     // and is able to write into a file.
     // The path parameter should be a string that describes the location of the file you wish to modify
     // The word parameter should also be a string that will be written to the file as individual lines
     // The number parameter should describe how many lines the file should have.
     // If the word is 'apple' and the number is 5, it should write 5 lines
     // into the file and each line should read 'apple'
     // The function should not raise any errors if it could not write the file.

        static void Main(string[] args)
        {
            string path = "appples";
            string word = "Apple";
            int number = 5;
            Writer(path, word, number);
        }
        static void Writer(string pa, string wo, int num)
        {
            try
            {
                List<string> tab = new List<string>(num);
                for (int a = 0; a <= num - 1; a++)
                {
                    tab.Add(wo);
                    File.AppendAllText(pa, wo + "\n");
                }
            }
            catch (IOException)
            {

            }
        }
    }
}
