using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Student class that has the same fields and methods as the Person class, and has the following additional
//fields:
//previousOrganization: the name of the student’s previous company / school
//skippedDays: the number of days skipped from the course
//methods:
//GetGoal(): prints "Be a junior software developer."
//Introduce(): prints "Hi, I'm name, a age year old gender from previousOrganization who skipped skippedDays days from the course already."
//SkipDays(numberOfDays): increases skippedDays by numberOfDays
//The Student class has the following constructors:
//Student(name, age, gender, previousOrganization): beside the given parameters, it sets skippedDays to 0
//Student(): sets name to Jane Doe, age to 30, gender to female, previousOrganization to The School of Life, skippedDays to 0

namespace GreenFoxInheritanceExcercise
{
    class Student : Person
    {
        string previousOrganization;
        int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            skippedDays = 0;
            this.previousOrganization = previousOrganization;
        }
        public Student() : base()
        {
            previousOrganization = "TheSchoolOfLIfe";
            skippedDays = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} from {previousOrganization} who skipped {skippedDays} days from the course already.");
        }
        public void SkipDays(int numberOfDays)
        {
            skippedDays -= numberOfDays;
        }

    }
}
