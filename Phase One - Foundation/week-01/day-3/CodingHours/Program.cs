using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyHours = 6;
            int semesterWeeks = 17;
            double WeekWorkHours = 52.0;
            int weekHours = dailyHours * 5;
            int semesterHours = weekHours * semesterWeeks;
            double semesterWorkHours = WeekWorkHours * semesterWeeks;
            
            double percentageOfCodingHoursInSemester = (semesterHours / semesterWorkHours) * 100.0;

            Console.WriteLine(semesterHours);
            Console.WriteLine(percentageOfCodingHoursInSemester);
        }
    }
}
