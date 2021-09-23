using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Check out what the ICloneable (.aspx) interface is
//Get your Student and other relevant classes from the Green Fox Organization Exercise
//Make the Student implement the ICloneable interface
//Implement the Clone() method, so it clones the student
//Instantiate John, a 20 years old male from BME
//Clone him into JohnTheClone
namespace GreenFoxInheritanceExcercise
{
    class Student : Person, ICloneable
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
        public object Clone()     //vytvoření klonu
        {
            return new Student(name, age, gender, previousOrganization);
        }

    }
}
