using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class Program
    {
       public static void Main(string[] args)
        {

            List<Trainer> trainers = new List<Trainer>();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] trainerInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = int.Parse(trainerInfo[3]);

                if (trainers.Any(trainer => trainer.Name == trainerName) == false)
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainer);
                }

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                trainers.First(trainer => trainer.Name == trainerName).Pokemon.Add(pokemon);
            }

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                string element = cmd;

                CheckPokemons(trainers, element);
            }

            foreach (Trainer trainer in trainers.OrderByDescending(trainer => trainer.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemon.Count}");
            }

        }
        private static void CheckPokemons(List<Trainer> trainers, string element)
        {
            foreach (Trainer trainer in trainers)
            {
                if (trainer.Pokemon.Any(pokemon => pokemon.Element == element))
                {
                    trainer.Badges++;
                }
                else
                {
                    foreach (Pokemon pokemon in trainer.Pokemon)
                    {
                        pokemon.Health -= 10;
                    }

                    trainer.Pokemon.RemoveAll(pokemon => pokemon.Health <= 0);
                }
            }
        }
    }
}
