using System;
using System.Text;

namespace UrlFixer
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https//www.reddit.com/r/nevertellmethebots";

            StringBuilder url = new StringBuilder("https//www.reddit.com/r/nevertellmethebots");
            url.Insert(5, ":");
            url.Replace("bots", "odds");
            Console.WriteLine(url);
        }
    }
}
