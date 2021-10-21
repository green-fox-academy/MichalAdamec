using System;

namespace PrintEven
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a <= 500; a++)
            {
                if (a%2 == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
