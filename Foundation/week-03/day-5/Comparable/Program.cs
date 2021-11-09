using System;
using System.Collections.Generic;

namespace Comparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Domino> dominoes = new List<Domino>();

            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            dominoes.Add(new Domino(6, 1));

            dominoes.Sort();

            foreach (Domino domino in dominoes)
            {
                Console.WriteLine(domino);
            }

            // the order of your dominoes should look like this: [[1,5], [2,4], [4,6], [5,2], [6,1], [6,7], [7,1]]
        }
    }
}
