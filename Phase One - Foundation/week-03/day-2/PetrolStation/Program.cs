using System;

//Create Station and Car classes

//Station
//it stores how much gas is avaliable: gasAmount
//it can refill a car: Refill(car):
//decreases the gasAmount by the capacity of the car (let us suppose that the car is empty) and
//increases the car's gasAmount

//Car
//it stores how much gas is actually present: gasAmount
//it stores the capacity of the tank: capacity
//create a constructor for the Car class where you:
//initialize gasAmount -> 0
//initialize capacity -> 100
namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Station station = new Station();

            station.Refill(car1);
            car1.PrintGas();
        }
    }
}
