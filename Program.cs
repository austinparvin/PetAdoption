using System;
using System.Collections.Generic;

namespace PetAdoption
{
    class Program
    {
        static void Main(string[] args)
        {
            var shelter = new List<string>();
            var isRunning = true;
            var currentPets = "";

            while (isRunning)
            {
                Console.WriteLine($"\nCurrent Pets");
                currentPets = shelter.Count == 1 ? "There is 1 pet." : $"There are {shelter.Count} pets.";
                Console.WriteLine(currentPets);

                for (var i = 0; i < shelter.Count; i++)
                {
                    var currentPet = shelter[i];
                    Console.WriteLine($"{i}: {currentPet}");

                }

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("('a') Add a pet?");
                Console.WriteLine("('d') Adopt a pet?");
                Console.WriteLine("('q') Quit\n");
                var input = Console.ReadLine();

                if (input.ToLower() == "a")
                {
                    Console.WriteLine("\nWhat pet do you want to add?");
                    var petToAdd = Console.ReadLine();
                    shelter.Add(petToAdd);
                }
                else if (input.ToLower() == "d")
                {
                    Console.WriteLine("\nWhat is the number of the pet you want to adopt?");
                    var petToAdopt = Console.ReadLine();
                    shelter.RemoveAt(int.Parse(petToAdopt));
                }
                else if (input.ToLower() == "q")
                {
                    isRunning = !isRunning;
                }
            }

            Console.WriteLine("\nGoodbye");

        }
    }
}
