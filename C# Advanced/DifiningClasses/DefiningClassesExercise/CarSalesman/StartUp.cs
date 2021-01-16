using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Trainer> trainers = new List<Trainer>();

            string command = Console.ReadLine();
            int appearance = 1;
            while (command != "Tournament")
            {
                string[] currentCommand = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string trainerName = currentCommand[0];
                string pokemonName = currentCommand[1];
                string pokemonElement = currentCommand[2];
                int pokemonHealth = int.Parse(currentCommand[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Any(n => n.Name == trainerName))
                {
                    Trainer trainer = trainers.Find(n => n.Name == trainerName);

                    trainer.AddPokemon(pokemon);
                }
                else
                {
                    Trainer trainer = new Trainer(trainerName, 0, appearance);

                    trainer.AddPokemon(pokemon);

                    trainers.Add(trainer);
                }

                appearance += 1;
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    List<Pokemon> pokemonList = trainer.ACollectionOfPokemon;

                    if (trainer.ACollectionOfPokemon.Any(p => p.Element == command))
                    {
                        trainer.NumberOfBadges += 1;
                    }
                    else
                    {
                        foreach (Pokemon pokemon in pokemonList)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.ACollectionOfPokemon.RemoveAll(p => p.Health <= 0);
                    }

                }

                command = Console.ReadLine();
            }

            trainers = trainers
                      .OrderByDescending(b => b.NumberOfBadges)
                      .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, trainers));

            // foreach (Trainer trainer in trainers)
            // {
            //     Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.ACollectionOfPokemon.Count}");
            // }
        }
    }
}
