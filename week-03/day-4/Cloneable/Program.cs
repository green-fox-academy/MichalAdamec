using GreenFoxInheritanceExcercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male", "BME");
            Student johnTheClone = (Student)john.Clone();

            john.Introduce();
            johnTheClone.Introduce();
        }
    }
}
