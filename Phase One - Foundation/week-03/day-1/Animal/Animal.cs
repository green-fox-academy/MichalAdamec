using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//    Create an Animal class
//Every animal has a hunger value, which is a whole number
//Every animal has a thirst value, which is a whole number
//When creating a new animal instance these values must be set to the default 50 value
//Every animal can eat() which decreases its hunger by one
//Every animal can drink() which decreases its thirst by one
//Every animal can play() which increases both its hunger and thirst by one

namespace Animal
{
    class Animal
    {
        private int Hunger = 50; // = atributy
        private int Thirst = 50;

        public Animal ()    //parametry přebírá z atributu
        {

        }
        public void eat()   //parametry přebírá z atributu
        {
            Hunger--;
        }
        public void drink() //parametry přebírá z atributu
        {
            Thirst--;
        }
        public void play()  //parametry přebírá z atributu
        {
            Hunger++;
            Thirst++;
        }
        public void Print() //parametry přebírá z atributu
        {
            Console.WriteLine($"The Animal has \nHunger: {Hunger}\nThirst: {Thirst}");
        }
    }
}
