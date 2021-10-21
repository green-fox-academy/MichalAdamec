using System;
using System.Linq;
using System.Collections.Generic;

//Create a Fox class with 3 properties: name, type and color.                    X
//Fill a list with at least 5 foxes, it's up to you how you name/create them.    X
//Write a LINQ Expression to find the foxes with green color.
//Write a LINQ Expression to find the foxes with green color and pallida type.

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fox> foxes = new List<Fox>();

            foxes.Add(new Fox("Lilly", "Artic", "white"));
            foxes.Add(new Fox("Billy", "Fennec", "red"));
            foxes.Add(new Fox("Sissy", "Gray", "gray"));
            foxes.Add(new Fox("Kitty", "Kit", "sand"));
            foxes.Add(new Fox("Silly", "Bengal", "red"));
            foxes.Add(new Fox("Tiny", "GreenFox", "green"));
            foxes.Add(new Fox("Fluffy", "Palida", "green"));

            var greenFox = foxes.Where(a => a.Color == "green");
            var greenPalida = foxes.Where(a => a.Color == "green" && a.Type == "Palida");

            foreach (var fox in greenPalida)
            Console.WriteLine(fox.Name);
        }
    }
}
