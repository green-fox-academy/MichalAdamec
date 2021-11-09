using System;

namespace VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            a += 10; 
            Console.WriteLine(a);

            int b = 100;
            b -= 7;
            Console.WriteLine(b);

            int c = 44;
            c *= 2;
            Console.WriteLine(c);

            int d = 125;
            d /= 5;
            Console.WriteLine(d);

            int e = 8;
            Console.WriteLine(e * e * e);
            
            int f1 = 123;
            int f2 = 345;
            bool res1 = true;
            bool res2 = false;
            if (f1 > f2)
            {
                Console.WriteLine(res1);
            }
            else 
            {
                Console.WriteLine(res2);
            }

            int g1 =350;
            int g2 = 200;
            bool re1 = true;
            bool re2 = false;
            if ((2 * g2) > g1)
            {
                Console.WriteLine(re1);
            }
            else
            {
                Console.WriteLine(re2);
            }

            double h = 1357988018575474;
            int divisor = 11;
            bool vysl1 = true;
            bool vysl2 = false;
            double vysledek = h % divisor;
            if (vysledek == 0)
            {
                Console.WriteLine(vysl1);
            }
            else 
            {
                Console.WriteLine(vysl2);
            }

            int i1 = 10;
            int i2 = 3;
            bool vysl3 = true;
            bool vysl4 = false;
            if (i1 > i2 * i2 && i1 < i2 * i2 * i2)
            {
                Console.WriteLine(vysl3);
            }
            else
            {
                Console.WriteLine(vysl4);
            }


            int j = 1521;
            int divis1 = 3;
            int divis2 = 5;
            bool vysla = true;
            bool vyslb = false;
            double vysle1 = j % divis1;
            double vysle2 = j % divis2;
            if (vysle1 == 0 || vysle2 == 0)
            {
                Console.WriteLine(vysla);
            }
            else
            {
                Console.WriteLine(vyslb);
            }
        }
    }
}
