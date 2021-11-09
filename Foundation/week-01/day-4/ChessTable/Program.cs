using System;

namespace ChessTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chess table.");
            Console.WriteLine();
            int number = 5;

            {
                for (int row = 1; row <= number; row++)
                {
                    string oo = "O";
                    string xx = "x";

                    //sudý řádek
                    if (row % 2 == 0)
                    {
                        for (int col = 1; col <= number; col++)
                        {
                            //oo a xx jsou v sudém řádku obrácené

                            if (col % 2 == 0)
                            {
                                Console.Write(xx);
                            }
                            else if (col % 2 != 0)
                            {
                                Console.Write(oo);
                            }
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                    //lichý řádek

                    else if (row % 2 != 0)
                    {
                        for (int col = 1; col <= number; col++)
                        {
                            if (col % 2 == 0)
                            {
                                Console.Write(oo);
                            }
                            else if (col % 2 != 0)
                            {
                                Console.Write(xx);
                            }
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
