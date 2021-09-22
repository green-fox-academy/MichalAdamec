using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Sponsor class that has the same fields and methods as the Person class, and has the following additional
//fields:
//company: name of the company
//hiredStudents: number of students hired
//method:
//Introduce(): prints "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
//Hire(): increase hiredStudents by 1
//GetGoal(): prints "Hire brilliant junior software developers."
//The Sponsor class has the following constructors:
//Sponsor(name, age, gender, company): beside the given parameters, it sets hiredStudents to 0
//Sponsor(): sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0

namespace GreenFoxInheritanceExcercise
{
    class Sponsor : Person
    {
        string company;
        int hiredStudents;

        public Sponsor(): base ()
        {
            company = "Google";
            hiredStudents = 0;
        }
        public Sponsor(string name, int age, string gender, string company) : base (name, age, gender)
        {
            hiredStudents = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }
        public void Hire()
        {
            hiredStudents += 1;
        }
    }
}
