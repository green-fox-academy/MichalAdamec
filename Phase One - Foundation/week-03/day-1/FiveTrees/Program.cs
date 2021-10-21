using System;

namespace FiveTrees
{
//    Create 5 trees
//Store the data of them in variables in your program
//for every tree the program should store its'
//type
//leaf color
//age
//sex
//you can use just variables, or lists and/or maps
    class Program
    {
        private class Tree
        {
            public string Type;
            public string LeafColor;
            public string Sex;
            public int Age;

            public Tree();
            {
                Type = type;
                LeafColor = color;
                Sex = sex;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            Tree oak = new Tree();
            oak.Type = "oak";
            oak.LeafColor = "green";
            oak.Sex = "male";
            oak.Age = 125;
            
            Tree Maple = new Tree("maple", "red", "male", 20);
            Tree Birch = new Tree("birch", "green", "male", 15);
            Tree Beech = new Tree("beech", "green", "male", 35);
            Tree CoconutTree = new Tree("coconutTree", "brown", "male", 125);


            Console.WriteLine(Maple.Sex);
            Console.ReadKey();
        }
    }
}
