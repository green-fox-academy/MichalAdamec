using System;
using System.Text;

namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";
            string insert = "always takes longer than ";
            StringBuilder fix = new StringBuilder(quote);
            fix.Insert(21, insert); 

            Console.WriteLine(fix);

            //int delka = quote.Length;
            //Console.WriteLine(delka);
        }
    }
}
