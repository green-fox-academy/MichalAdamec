using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Create a POST /sith endpoint
//That receives a simple json object:
//    "text": "This is my example sentence. Just for fun.

//And responds with a simplified yoda speak simply switching every 2 words:
//    "sith_text": "Is this example my sentence. Arrgh. Uhmm. For just fun. Err..err.err."

//it keeps the capital positions and the end of sentences
//if a sentence doesn't contain even number of words, it leaves the last as is
//always puts (one or two) random things at the end of sentences
//if the input doesn't contain the text or its empty, respond with

namespace Frontend.Models
{
    public class ReverserOfSith
    {
        //public string Text { get; set; }
        //public string Reverse()
        //{
        //    string[] randomSounds = { "Hmmm.", "Err..err.err.", "Arrgh.", "Uhmm." };

        //    Random rd = new Random();
        //    rd.Next(0, 4);

        //    List<string> list = Text.Split(" ").ToList();
        //    //List<string> reversed = new List<string>();
        //    string reversed = string.Empty;

        //    for (int a = 0; a < list.Count; a++)
        //    {
        //        if (!list[a].Contains('.') && !list[a + 1].Contains('.'))
        //        {
        //            list[a].ToLower();
        //            reversed += list[a + 1] + list[a];
        //            a++;
        //        }
        //        else
        //        {

        //        }

        //        //        }
        //    }
        //}
    }
}
