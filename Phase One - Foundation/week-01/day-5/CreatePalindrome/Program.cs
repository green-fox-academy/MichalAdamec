using System;

//Create a function named createPalindrome() following your current language's style guide.
//It should take a string, create a palindrome from it and then return it.

namespace CreatePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "olej";
            string palindrome = PalindromCreator(word);
            Console.WriteLine($"Palindrom ze slova {word} je {palindrome}");
        }
        public static string PalindromCreator(string word)
        {
            string reversed = "";
            for (int a = word.Length - 1; a >= 0; a--)
            {
                reversed += word[a];
            }
            string palindrome = word + reversed;
            return palindrome;
        }
    }
}
