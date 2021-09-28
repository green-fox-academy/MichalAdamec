using System;

//Write a function, that takes two strings and returns a boolean value based on if the two strings are Anagramms or not.
//Create a test for that.

//Convert both strings to character arrays.
//Sort the character arrays in ascending/descending order, but use the same ordering on both of the character sets.
//Create two strings out of the two sorted character set arrays.
//Compare the strings.
//If they are not equal, they are not Anagrams.

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            public static bool CompareTwoWords(string first, string second)
            {
                char[] one = first.ToLower().ToCharArray();         //string na array; převedení na malá písmena (jinak by nefungoval Sort -
                char[] two = second.ToLower().ToCharArray();        // - Sort upřednostňuje velká písmena před pořadím v abecedě)

                Array.Sort(one);               //seřazení dle abecedy
                Array.Sort(two);

                string newFirst = new string(one);      //převede array zpět na string
                string newSecond = new string(two);

                if (newFirst == newSecond)
                {
                    return true;
                }
                else
                    return false;
            }
        }

    }
}
