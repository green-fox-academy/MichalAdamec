using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
