using System;

//Create a Sharpie class
//We should know the followings about each sharpie:
//color(which should be a string),
//width(which will be a floating point number) and the
//inkAmount (another floating point number)
//We need to specify the color and the width at creation
//Every sharpie is created with a default inkAmount value: 100
//We can Use() the sharpie objects: using it decreases inkAmount by 10
namespace Sharpie
{
    public class Sharpie
    {
        private string Color;
        private double Width;
        private double InkAmount = 100;

        public Sharpie()
        {
            this.Width = Width;
            this.Color = Color;
        }
        public void Use()
        {
            InkAmount -= 10;
        }
        public void Print()
        {
            Console.WriteLine($"Amount of ink is {InkAmount}/100");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie tisk = new Sharpie();
            tisk.Use();
            tisk.Use();
            tisk.Use();

            tisk.Print();
        }
    }
}
