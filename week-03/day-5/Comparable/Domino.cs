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
     public class Domino : IComparable<Domino>
     {
            private readonly int[] Values;

            public Domino(int valueA, int valueB)
            {
                this.Values = new int[] { valueA, valueB };
            }

        public int CompareTo(Domino domino)
        {

            //for (int a = 0; a < Values.Length; a++)
            //{
            //    int One = Values[a];
            //    int Other = domino.GetValues()[a];

            //    if (One > Other)
            //    {

            //    }
            //}


            int lvl;
            int intA = Values[0];
            int intB = Values[1];
            int intC = domino.GetValues()[0];
            int intD = domino.GetValues()[1];

            if (intA > intC)
            {
                lvl = 1;
            }
            else if (intA < intC)
            {
                lvl = -1;
            }
            else
            {
                if (intB > intC)
                {
                    lvl = 1;
                }
                else if (intB < intC)
                {
                    lvl = -1;
                }
                else
                {
                    lvl = 0;
                }
            }
            return lvl;
        }
        public int[] GetValues()
            {
                return Values;
            }
        public override string ToString()
        {
            return $"{Values[0]} - {Values[1]}";
        }
     }
}
