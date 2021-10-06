using System;
using System.Collections.Generic;

//Create an empty map where the keys are integers and the values are characters X
//Print out whether the map is empty or not X
//Add the following key-value pairs to the map  X
//Key	Value
//97	a
//98	b
//99	c
//65	A
//66	B
//67	C
//Print all the keys    X
//Print all the values  X
//Add value D with the key 68   X
//Print how many key-value pairs are in the map X
//Print the value that is associated with key 99    X
//Remove the key-value pair where with key 97   X
//Print whether there is an associated value with key 100 or not    X
//Remove all the key-value pairs
namespace MapIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, char> {
                {99,'c'},{65,'A'},{66,'B'},{67,'C'}
            };
            dict.Add(97, 'a');
            dict[98] = 'b';
            dict[68] = 'D';

            int dictcapacity = dict.Count;
            Console.WriteLine($"Dictionary capacity: {dictcapacity}");
            foreach (var Key in dict.Keys)
            Console.WriteLine($"Keys: {Key}");
            Console.WriteLine();
            foreach (var value in dict.Values)
            Console.WriteLine($"Keys: {value}");
            Console.WriteLine();
            Console.WriteLine($"Value is {dict[99] }");
            dict.Remove(97);
            Console.WriteLine();
            bool isValue = dict.TryGetValue(100, out char val);
            if (isValue == true)
                Console.WriteLine($"Value is: {val}");
            else
                Console.WriteLine("no such value in dictionary");
            Console.WriteLine();
            Console.WriteLine();
            foreach(var kvp in dict)
            Console.WriteLine($"KVP: {kvp}");
            dict.Clear();


        }
    }
}
