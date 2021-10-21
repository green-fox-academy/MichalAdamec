using System;
using System.Linq;

//Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:
//string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS", "AMALFI" };

            var filteredCities = cities.Where(w => w[0] == 'A' && w[w.Length - 1] == 'I');
            //var filteredCities = cities.Where(w => w.StartsWith('A') && w.EndsWith('I'));

            foreach (var city in filteredCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
