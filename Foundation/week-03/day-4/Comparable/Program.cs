using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Check out what is the IComparable interface
//Get your Domino class
//Implement the IComparable interface on the Domino
//Why? We want to be able to sort List of Dominoes based on the result of Domino.CompareTo()
//Domino.CompareTo() will help us sort based on our custom criteria:
//Compare Dominoes based on their first value, and in case those are the same, 
//compare them based on second (see example for dominoes with Dominoes 6,7 and 6,1)
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
        }
    }
}
