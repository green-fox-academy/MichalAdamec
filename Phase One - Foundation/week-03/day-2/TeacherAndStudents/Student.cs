using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudents
{
    class Student
    {
        public Student()
        { }
        public void Learn()
        {
            Console.WriteLine("the student is actually learning");
        }
        public void Question(Teacher teacher)
        {
            teacher.GiveAnswer();
        }
    }
}
