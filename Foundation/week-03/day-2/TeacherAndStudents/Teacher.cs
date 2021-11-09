using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAndStudents
{
    class Teacher
    {
        public Teacher()
        { }
        public void GiveAnswer()
        {
            Console.WriteLine("the teacher is answering a question");
        }
        public void Teach(Student student)
        {
            student.Learn();
        }
    }
}
