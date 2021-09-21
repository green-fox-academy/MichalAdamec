using System;
using System.Collections.Generic;

namespace Dices
{
    public class DiceSet
    {
        private Random randomValue = new Random();
        private int[] dice = new int[6];            //array do které vkládám výsledky hodů


        public int[] Roll()         //hodí jednu po druhé všemi kostkami a přiřadí jim náhodnou hodnotu 1-6
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = randomValue.Next(1, 7);
            }
            return dice;
        }

        public int[] GetCurrent()       //vrátí hodnoty všech kostek
        {
            return dice;
            Console.WriteLine(dice);
        }

        public int GetCurrent(int i)    //vrátí hodnotu jedné konkrétní kostky [i]
        {
            return dice[i];
        }

        public void Reroll()
        {
            for (int i = 0; i < dice.Length; i++)   //znovu hodí všemi kostkami jednu po druhé a přiřadí náhodnou hodnotu 1-6
            {
                dice[i] = randomValue.Next(1, 7);
            }
        }

        public void Reroll(int k)                   //přiřadí náhodnou hodnotu kostce [k]
        {
            dice[k] = new Random().Next(1, 7);
        }
        public void PrintAll()                      //vytiskne všechny kostky
        {
            foreach (int numb in dice)
            {
                Console.Write($"/{numb} / ");               
            }
            Console.WriteLine();
        }
        public bool AllSix()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] != 6)
                {
                    return false;
                }           
            }
            return true;
        }

    }
}