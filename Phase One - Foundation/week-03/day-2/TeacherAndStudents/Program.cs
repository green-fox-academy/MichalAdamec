using System;

//Create Student and Teacher classes
//Student
//learn() -> prints: the student is actually learning
//question(teacher)->calls the teacher's giveAnswer() method
//Teacher
//teach(student) -> calls the student's learn() method
//giveAnswer() -> prints: the teacher is answering a question
//Instantiate a Student and Teacher object
//Call the student's question() method and the teacher's teach() method
namespace TeacherAndStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            student.Question(teacher);
            teacher.Teach(student);

        }
    }
}
