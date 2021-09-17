using System;

namespace Power
{
    class Program
    {
        //Given base and n that are both 1 or more,
        //compute recursively(no loops) the value of base 
        //to the n power, so powerN(3, 2) is 9 (3 squared).
        static void Main(string[] args)
        {
            int result = numbPow(3, 4);
            Console.WriteLine(result);

            static int numbPow (int numb, int pow)
            {
                if (pow == 1)
                {
                    return numb;
                }
                else
                {   
                    return numbPow(numb, pow - 1) * numb;
                }
            }
        }
    }
}
