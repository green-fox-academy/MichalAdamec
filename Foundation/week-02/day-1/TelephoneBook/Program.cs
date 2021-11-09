using System;
using System.Collections.Generic;

//We are going to represent our contacts in a map where both the keys and values are strings.
//Create a map with the following key-value pairs:      X
//Name(key)  Phone number(value)
//William A.Lathan   405-709-1865
//John K. Miller  402-247-8568
//Hortensia E. Foster 606-481-6467
//Amanda D. Newland   319-243-5613
//Brooke P. Askew 307-687-2982

//Create an application which prints out the answers to the following questions:
//What is John K. Miller's phone number?        X
//Whose phone number is 307-687-2982?
//Do we know Chris E.Myers' phone number?

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>
            {
                {"William A.Lathan", "405-709-1865" },
                {"John K. Miller", "402-247-8568" },
                {"Hortensia E. Foster", "606-481-6467" },
                {"Amanda D. Newland", "319-243-5613" },
                {"Brooke P. Askew", "307-687-2982" }
            };
            GetNumber(phoneBook, "John K. Miller");
            GetName(phoneBook, "307-687-2982");
            ExistsNumber(phoneBook, "Chris E.Myers");
            foreach (var person in phoneBook)
                Console.WriteLine(person);
        }
        public static void GetName(SortedDictionary<string, string> dict, string number)
        {
            if (!dict.ContainsValue(number))
                Console.WriteLine("Number doesnt exist.");
            foreach (var name in dict)
            {
                if(name.Value == number)
                    Console.WriteLine($"{name.Key}, {number}");
            }
            Console.WriteLine();

        }
        public static void GetNumber(SortedDictionary<string, string> dict, string name)
        {
            var value = dict[name];
            if (dict.ContainsKey(name))
                Console.WriteLine($"{name}, {value}");
            else
                Console.WriteLine("Name doesnt exist.");
            Console.WriteLine();
        }
        public static void ExistsNumber(SortedDictionary<string, string> dict, string name) 
        {
            if (dict.ContainsKey(name))
                Console.WriteLine($"Yes, we know {name} number.");
            else
                Console.WriteLine($"No, we dont know {name} number.");
            Console.WriteLine();

        }
    }
}
