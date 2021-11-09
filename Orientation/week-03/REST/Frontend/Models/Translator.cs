using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Create a POST /translate endpoint
//That receives a simple json object:
//    "text": "Ez egy példamondat. Remélem célbatalál.",
//  "lang": "hu"
//And responds with the translated text and its language:
//    "translated": "Evez evegy pévéldavamovondavat. Revemévélevem cévélbavavtavalávál.",
//  "lang": "teve"
//from hungarian translate to teve language

namespace Frontend.Models
{
    public class Translator
    {
        public string Text { get; set; }
        public string Lang { get; set; }

        public string Translate()
        {
            List<string> list = Text.Split(" ").ToList();
            List<char> charList = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'á', 'é', 'í', 'ó', 'ú','A','E','I','Y','O', 'U' };

            string completed = string.Empty;

            for (int a = 0; a < list.Count; a++)
            {
                string newWord = string.Empty;
                string word = list[a];

                for (int b = 0; b < word.Count(); b++)
                {
                    char letter = word[b];
                    if (charList.Contains(letter))
                    {
                        if(char.IsUpper(letter))
                        newWord += (letter + "v" + char.ToLower(letter));

                        else
                            newWord += (letter + "v" + letter);
                    }
                    else
                    {
                        newWord += letter;
                    }
                }
                completed += newWord + " ";
            }
            return completed;
        }
    }
}
