using System;
using System.Collections.Generic;

//We are going to represent our expenses in a list containing integers.
//Create a list with the following items:
//500, 1000, 1250, 175, 800 and 120
//Create an application which prints out the answers to the following questions:
//How much did we spend?        X
//Which was our greatest expense?   X
//Which was our cheapest spending?  X
//What was the average amount of our spendings?

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> finance = new List<int> { 500, 1000, 1250, 175, 800, 120 };

            Console.WriteLine($"We spent: {Spent(finance)}");

            Console.WriteLine($"Our greatest expense is: {GreatestExpense(finance)}");

            Console.WriteLine($"Our cheapest expense is: {CheapestExpense(finance)}");

            Console.WriteLine($"Average amount spent is: {AverageSpent(finance)}");
        }
        public static int Spent(List<int> list)
        {
            int sum = 0;
            foreach (int amount in list)
                sum += amount;
            return sum;
        }
        public static int GreatestExpense(List<int> list)
        {
            int highest = 0;
            foreach (int amount in list)
            {
                if (amount > highest)
                    highest = amount;
            }
            return highest;
        }
        public static int CheapestExpense(List<int> list)
        {
            int lowest = GreatestExpense(list);
            foreach (int amount in list)
            {
                if (amount < lowest)
                    lowest = amount;
            }
            return lowest;
        }
        public static int AverageSpent(List<int> list)
        {
            int average = (Spent(list) / list.Count);
            return average;
        }
    }
}
