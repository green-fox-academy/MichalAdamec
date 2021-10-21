using System;

namespace PartyIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napiš počet chlapců!");
            string klu = Console.ReadLine();
            int kluci = Int32.Parse(klu);

            Console.WriteLine("Napiš počet děvčat!");
            string hol = Console.ReadLine();
            int holky = Int32.Parse(hol);

            if (((holky + kluci)>=20) && (kluci == holky))
            {
                Console.WriteLine("The party is excellent!");
            }

            //vyřešit ratio

            else if ((holky + kluci) >= 20 && (kluci != holky) && (holky >= 1))
            {
                Console.WriteLine("Quite a cool party!");
            }
            else if (holky + kluci < 20)
            {
                Console.WriteLine("Average party...");
            }
            else if (holky == 0)
            {
                Console.WriteLine("Sausage party");

            }

        }
    }
}
