using System;

namespace MileToKmConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napište vzdálenost v mílích!");
            double mile = Convert.ToInt32(Console.ReadLine());
            double km = (mile * 1.609344);
            Console.WriteLine(mile + " mil je " + km + " kilometrů");
        }
    }
}
