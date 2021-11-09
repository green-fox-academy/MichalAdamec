using System;
using System.Collections.Generic;

//We are going to represent our products in a map where the keys are strings
//representing the product's name and the values are numbers representing the product's price.
//Create a map with the following key-value pairs:

//Product name(key)  Price(value)
//Eggs 200
//Milk 200
//Fish 400
//Apples 150
//Bread 50
//Chicken 550

//Create an application which prints out the answers to the following questions:
//How much is the fish?                     X
//What is the most expensive product?       X
//What is the cheapest product?             X
//What is the average price?                X
//How many products' price is below 300?    X
//Is there anything we can buy for exactly 125? X

namespace ProductDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, int>
            {
                {"Eggs", 200 },
                {"Milk", 200 },
                {"Fish", 400 },
                {"Apples", 150 },
                {"Bread", 50 },
                //{"something", 125 },
                {"Chicken", 550 }
            };
            string product = "Fish";
            Console.WriteLine($"The {product} is: {database[product]}");
            Console.WriteLine();
            MostExpensive(database);
            Console.WriteLine();
            Cheapest(database);
            Console.WriteLine();
            AveragePrice(database);
            Console.WriteLine();
            Below300(database);
            Console.WriteLine();
            Exactly125(database);

        }
        public static void MostExpensive(Dictionary<string, int> list)
        {
            int price = 0;
            string item = "";
            foreach(var product in list)
            {
                if (product.Value > price)
                {
                    price = product.Value;
                    item = product.Key;
                }
            }
            Console.WriteLine($"The most expensive product is: {item}");

        }
        public static void Cheapest(Dictionary<string, int> list)
        {
            int price = 10000;
            string item = "";
            foreach (var product in list)
            {
                if (product.Value < price)
                {
                    price = product.Value;
                    item = product.Key;
                }
            }
            Console.WriteLine($"The cheapest product is: {item}");
        }
        public static void AveragePrice(Dictionary<string, int> list)
        {
            int sum = 0;
            foreach(var product in list)
            {
                sum += product.Value;
            }
            Console.WriteLine($"The average price is: {sum / list.Count}");
        }
        public static void Below300(Dictionary<string, int> list)
        {
            int sum = 0;
            foreach (var product in list)
            {
                if(product.Value < 300)
                sum += 1;
            }
            Console.WriteLine($"{sum} items have the price below 300.");
        }
        public static void Exactly125(Dictionary<string, int> list)
        {
            bool isTrue = false;
            foreach(var product in list)
            {
                if (product.Value == 125)
                    isTrue = true;
            }
            Console.WriteLine($"Is there anything we can buy for exactly 125? {isTrue}");
        }
    }
}
