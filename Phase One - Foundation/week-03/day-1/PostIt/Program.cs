using System;
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
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt("Orange", "Idea1", "Blue");
            PostIt postIt2 = new PostIt("Pink", "Awesome", "Black");
            PostIt postIt3 = new PostIt("Yellow", "Superb!", "Green");


            postIt1.Print();
        }
    }
}
