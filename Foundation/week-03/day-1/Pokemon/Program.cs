using System;
using System.Collections.Generic;

// Every pokemon has a name and a type.
// Certain types are effective against others, e.g. water is effective against fire.
// Ash has a few pokemon.
// A wild pokemon appeared!
// Which pokemon should Ash use?

namespace GreenFoxAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            Pokemon wildPokemon = new Pokemon("Oddish", "grass", "water");

            int lengthOfList = pokemonOfAsh.Count;
            for (int a = 0; a < lengthOfList; a++)
            {
                //if (pokemonOfAsh[a].IsEffectiveAgainst(wildPokemon))
                if (pokemonOfAsh[a].EffectiveAgainst == wildPokemon.Type)
                {
                    Console.Write($"I choose you, {pokemonOfAsh[a].Name}!");
                }
            }
        }
        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Bulbasaur", "grass", "water"),
                new Pokemon("Pikachu", "electric", "water"),
                new Pokemon("Charizard", "fire", "grass"),
                new Pokemon("Pidgeot", "flying", "fighting"),
                new Pokemon("Kingler", "water", "fire")
            };
        }
    }
}