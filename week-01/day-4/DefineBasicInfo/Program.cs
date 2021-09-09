using System;

namespace DefineBasicInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name= "Michal";
            int age = 34;
            double height = 1.85;
            bool married = false;
            Console.WriteLine(name);
            Console.WriteLine(age+" let");
            Console.WriteLine(height+" m");
            Console.WriteLine("ženatý "+married);
        }
    }
}
