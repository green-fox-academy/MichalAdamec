using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Person class with the following fields:
//name: the name of the person
//age: the age of the person (whole number)
//gender: the gender of the person (male / female)
//And the following methods:
//GetGoal(): prints "My goal is: Live for the moment!"
//Introduce(): prints "Hi, I'm name, a age year old gender."
//And the following constructors:
//Person(name, age, gender)
//Person(): sets name to Jane Doe, age to 30, gender to female

namespace GreenFoxInheritanceExcercise
{
    class Person
    {
        protected int age;
        protected string name;
        protected string gender;

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }
        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.name}, a {this.age} year old {this.gender}.");
        }

    }
}
