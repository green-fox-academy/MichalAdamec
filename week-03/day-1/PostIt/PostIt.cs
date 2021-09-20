using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//    Create a PostIt a class that has
//a BackgroundColor
//a Text on it
//a TextColor
//Create a few example post-it objects:
//an orange with blue text: "Idea 1"
//a pink with black text: "Awesome"
//a yellow with green text: "Superb!"

namespace PostIt
{
    class PostIt
    {
        string BackgroundColor;
        string Text;
        string TextColor;

        public PostIt(string backgroundColor, string text, string textColor)
        {
            BackgroundColor = backgroundColor;
            Text = text;
            TextColor = textColor;

        }
        public void Print()
        {
            Console.WriteLine($"background color is: {BackgroundColor}, text is: {Text}, Text color is: {TextColor}");
        }
    }
}
