using System;

//Create a function named isAnagram() following your current language's style guide.
//It should take two strings and return a boolean value depending on whether it's an anagram or not.

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "silent";
            string word2 = "listen";
            bool isTrue = IsAnagram(word1, word2);
            Console.WriteLine($"Is {word1} and {word2} anagrams? {isTrue}");
        }
        public static bool IsAnagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
                return false;
            else
            {
                char[] array1 = word1.ToLower().ToCharArray();
                char[] array2 = word2.ToLower().ToCharArray();
                Array.Sort(array1);
                Array.Sort(array2);
                string w1 = new string(array1);
                string w2 = new string(array2);
                if (w1 == w2)
                    return true;
                else
                    return false;
            }
        }
    }
}
