using System;
using System.Text;

// - Create an array variable named `animals`
//   with the following content:
//   `["koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
//     "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"]`
// - Add all elements an `"a"` at the end

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = new string[]
            {"koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
            "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"};
            foreach (string animal in animals)
            {
                string myString = animal;
                string newAnima = myString.Insert(myString.Length, "a");
                Console.WriteLine(myString);
                Console.WriteLine(newAnima);
                Console.WriteLine();

            }
            Console.WriteLine();
        }
    }
}
