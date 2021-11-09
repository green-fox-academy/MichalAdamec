using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a sum method in your class which takes a List of integers as parameter
//It should return the sum of the elements in the list
//Follow these steps:
//Create an xUnit project
//Add a Test class to your project
//Add a new Test case in it
//Instantiate your class (arrange, act, assert)
//create a list of integers
//use the Assert.Equal() to test the result of the created sum method
//Run them
//Create different tests where you test your method with:
//an empty list
//a list that has one element in it
//a list that has multiple elements in it
//a null
//Run them
//Fix your code if needed

namespace SumTest
{
    public class Class1
    {
        public int SumMethod(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            else
            {
                for (int a = 0; a < numbers.Count; a++)
                {
                    sum += numbers[a];
                }
                return sum;
            }
        }
    }
}
