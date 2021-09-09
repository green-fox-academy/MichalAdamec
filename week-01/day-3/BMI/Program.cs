using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = 81.2;
            double height = 1.78;
            double BMI = kg / (height * height);
            Console.WriteLine("kg = " + kg);
            Console.WriteLine("height = " + height);
            Console.WriteLine("BMI = "+ BMI);
        }
    }
}
