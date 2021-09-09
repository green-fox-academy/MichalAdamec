using System;

namespace SecondsInDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;
            int wholeDaySeconds = 86400;
            int passedSeconds = (currentHours * 3600 + currentMinutes * 60 + currentSeconds);
            int remainingSeconds = (wholeDaySeconds - passedSeconds);

            Console.WriteLine(remainingSeconds);
        }
    }
}
