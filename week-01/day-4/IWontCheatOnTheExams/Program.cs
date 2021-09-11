using System;

namespace IWontCheatOnTheExams
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "I wont cheat on the exam!";
            int Number = 1;
            for (int a = 1; a <= 100; a++, Number++)
            {
                Console.WriteLine(Number + " " + phrase);
            }
        }
    }
}
