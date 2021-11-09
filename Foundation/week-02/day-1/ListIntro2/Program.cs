using System;
using System.Collections.Generic;


//Create a list ('List A') which contains the following values  X
//Apple, Avocado, Blueberries, Durian, Lychee                   X
//Create a new list('List B') with the values of List A         X
//Print out whether List A contains "Durian" or not             X
//Remove "Durian" from List B                                   X
//Add "Kiwifruit" to List A after the 4th element       X
//Compare the size of List A and List B                 X
//Get the index of "Avocado" from List A        X
//Get the index of "Durian" from List B         X
//Add "Passion Fruit" and "Pomelo" to List B in a single statement      X
//Print out the 3rd element from List A
namespace ListIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> A = new List<string>{ "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };
            List<string> B = new List<string>{ "Apple", "Avocado", "Blueberries", "Durian", "Lychee" };

            Console.WriteLine(A.Contains("Durian"));
            Console.WriteLine();

            A.RemoveAt(1);
            B.Remove("Durian");
            A.Insert(4, "Kiwifruit");

            Console.WriteLine($"A count: {A.Count}, B count: {B.Count}");
            Console.WriteLine();

            Console.WriteLine(A.IndexOf("Avocado"));
            Console.WriteLine(B.IndexOf("Durian"));
            B.AddRange(new List<string>{ "Passion Fruit", "Pomelo"});
            Console.WriteLine();
            foreach( string a in A)
                Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(A[2]);
            Console.WriteLine();
            foreach (string a in B)
                Console.WriteLine(a);
            int capacity = B.Capacity;
            Console.WriteLine(capacity);

        }
    }
}
