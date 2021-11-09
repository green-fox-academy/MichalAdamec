using System;

//Create Counter class
//which has a counter (integer) field
//at creation it should have a default value 0
//there are two ways to create the class:
//with 0 input parameters
//with 1 input parameter called counter which is set as the initial value of the counter field
//we can add another whole number to this counter: Add(number)
//we can just increase the counter's value by one: Add() (no parameters)
//we can Get() the current counter value
//and we can Reset() the counter to the initial value set during the construction of the class
namespace Counter
{
    public class Counter
    {
        private int CounteR = 0;

        public Counter()
        {
        }
        public void Add()
        { 
            CounteR++;
        }
        public int Get()
        { return CounteR; }
        public void Reset()
        { CounteR = 0; }

        public void Print()
        { Console.WriteLine($"Counter is: {CounteR}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Add();
            counter.Add();
            counter.Get();
            counter.Reset();
            counter.Print();
        }
    }
}
