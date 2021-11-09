using System;
using System.Collections.Generic;

//We are going to represent a shopping list in a list containing strings.
//Create a list with the following items:
//ˇ "eggs", "milk", "fish", "apples", "bread" and "chicken"

//Create an application which prints out the answers to the following questions:
//Do we have milk on the list?
//Do we have bananas on the list?

namespace ShoppingList1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shoppingList = new List<string> { "eggs", "milk", "fish", "apples", "bread", "chicken" };
            string food = "bananas";
            bool isOnTheList = IsOnTheList(shoppingList, food);
            Console.WriteLine($"Do we have {food} on the list? {isOnTheList}");
        }
        public static bool IsOnTheList(List<string> list, string name)
        {
            if (list.Contains(name))
                return true;
            else
                return false;
        }
    }
}
