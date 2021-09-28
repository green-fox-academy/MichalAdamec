using System;
using Xunit;
using SumTest;
using System.Collections.Generic;

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

namespace SumMethodTest
{
    public class UnitTest1
    {
        Class1 testMethod = new Class1();

        [Fact]
        public void TestBasic()
        {
            //arrange
            Class1 testMethod = new Class1();
            List<int> input = new List<int> { 1, 5, 8, 9 };

            //act
            int output = testMethod.SumMethod(input);

            //assert
            Assert.Equal(23, output);
        }
        [Fact]
        public void TestEmptyList()
        {
            //arrange
            List<int> input = new List<int> { };

            //act
            int output = testMethod.SumMethod(input);

            //assert
            Assert.Equal(0, output);
        }
        [Fact]
        public void TestOneElementList()
        {
            //arrange
            List<int> input = new List<int> {23};

            //act
            int output = testMethod.SumMethod(input);

            //assert
            Assert.Equal(23, output);
        }
        [Fact]
        public void TestMultipleElementList()
        {
            //arrange
            List<int> input = new List<int> {3, 3, 3, 3, 3, 3, 3, 2 };

            //act
            int output = testMethod.SumMethod(input);

            //assert
            Assert.Equal(23, output);
        }
        [Fact]
        public void TestNull()
        {
            //arrange
            List<int> input = new List<int> {};

            //act
            int output = testMethod.SumMethod(null);

            //assert
            Assert.Equal(0, output);
        }
    }
}
