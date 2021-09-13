using System;
using System.Collections.Generic;

namespace MapIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, char> {};
            int dictcapacity = dict.Count;
            Console.WriteLine(dictcapacity);
            dict.Add(97, ' a');

        }
    }
}
