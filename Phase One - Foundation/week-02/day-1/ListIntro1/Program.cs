using System;
using System.Collections.Generic;

namespace ListIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            Console.WriteLine($"Number of names: {names.Count}");
            Console.WriteLine();
            names.Add("William");
            Console.WriteLine($"List empty? {names.Count == 0}");
            names.Add("John");
            names.Add("Amanda");
            Console.WriteLine();
            Console.WriteLine($"Number of names: {names.Count}");
            Console.WriteLine();
            Console.WriteLine($"3rd name: {names[2]}");
            Console.WriteLine();
            Console.WriteLine("List of names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            for (int i = 0; i <= names.Count - 1; i++)
            {
                Console.WriteLine($"{i + 1}. " + names[i]);
            }
            names.RemoveAt(1);
            Console.WriteLine();
            Console.WriteLine("Reversed:");
            for (int i = names.Count - 1; i >= 0; i--)
            {               
                Console.WriteLine(names[i]);
            }
            names.Clear();


        }
    }
}
