using System;
using System.Text;

namespace TodoPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            string todoText = " - Buy milk\n";
            StringBuilder fix = new StringBuilder(todoText);
            fix.Insert(0, "My todo:\n");
            fix.Append(" - Download games\n");
            fix.Append("    - Diablo\n");

            Console.WriteLine(fix);
        }
    }
}
