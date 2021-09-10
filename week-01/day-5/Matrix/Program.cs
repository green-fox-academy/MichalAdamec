using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int mlenght = 4;
            int[,] matrix = new int[mlenght, mlenght];


            for (int row = 0; row < mlenght; row++)
            {
                // Console.WriteLine(matrix [row,0]);

                for (int col = 0; col < mlenght; col++)
                {
                    matrix[row, col] = 0;
                    if (row == col)
                    {
                        matrix[row,col] = 1;
                    }

                    Console.Write(matrix[row,col] + " ");

                   //Console.Write(row + "," + col + " ");
                }
                Console.WriteLine();
            }



        }
    }
}
