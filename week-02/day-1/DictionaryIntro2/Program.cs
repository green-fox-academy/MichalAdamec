using System;
using System.Collections.Generic;

//Create a map where the keys are strings and the values are strings with the following initial values      X
//Key	Value                                   X
//978-1-60309-452-8	A Letter to Jo
//978-1-60309-459-7	Lupus
//978-1-60309-444-3	Red Panda and Moon Bear
//978-1-60309-461-0	The Lab

//Print all the key-value pairs in the following format         X
//A Letter to Jo (ISBN: 978 - 1 - 60309 - 452 - 8)
//Lupus(ISBN: 978 - 1 - 60309 - 459 - 7)
//Red Panda and Moon Bear (ISBN: 978 - 1 - 60309 - 444 - 3)
//The Lab(ISBN: 978 - 1 - 60309 - 461 - 0)

//Remove the key-value pair with key 978-1-60309-444-3      X
//Remove the key-value pair with value The Lab              X
//Add the following key-value pairs to the map              X
//Key	Value
//978-1-60309-450-4	They Called Us Enemy
//978-1-60309-453-5	Why Did We Trust Him?
//Print whether there is an associated value with key 478-0-61159-424-8 or not      X
//Print the value associated with key 978-1-60309-453-5         X
namespace DictionaryIntro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"978-1-60309-452-8", "A Letter to Jo"},{"978-1-60309-459-7", "Lupus"}, {"978-1-60309-444-3", "Red Panda and Moon Bear"},
                {"978-1-60309-461-0", "The Lab" }
            };
            
            dict.Remove("978-1-60309-444-3");

            string value = "";
            foreach (var kvp in dict)
                if (kvp.Value == "The Lab")
                    value = kvp.Key;
            dict.Remove(value);

            dict.Add("978-1-60309-450-4", "They Called Us Enemy");
            dict.Add("978-1-60309-453-5", "Why Did We Trust Him?");

            bool val = dict.TryGetValue("478-0-61159-424-8", out value);
            if (val)
                Console.WriteLine(value);
            else
                Console.WriteLine("Key doesnt exist.");
            Console.WriteLine();

            Console.WriteLine(dict["978-1-60309-453-5"]);
            Console.WriteLine();

            foreach (var kvp in dict)
                Console.WriteLine($"{kvp.Value} (ISBN: {kvp.Key})");
            

            Console.WriteLine();
        }
    }
}
