using System;
using System.Text;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string toBeReversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            int leng = toBeReversed.Length;
            for (int a = leng - 1; a >= 0; a--)
            {
                Console.Write(toBeReversed[a]);
            }
        }
    }
}
