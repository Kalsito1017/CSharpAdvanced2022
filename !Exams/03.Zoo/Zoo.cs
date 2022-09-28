using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Zoo
    {
        public List<Animal> Animals { get; set; }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.Animals = new List<Animal>();
        }
        public string AddAnimal(Animal animal)
        {
            if (Animals.Count < Capacity)
            { 
                    if (string.IsNullOrWhiteSpace(animal.Species))
                    {
                        return "Invalid animal species.";
                    }
                    if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                    {
                        return "Invalid animal diet.";
                    }
                
                Animals.Add(animal);
                
                return $"Successfully added {animal.Species} to the zoo.";

            }
            return "The zoo is full.";
        }
        public int RemoveAnimals(string species)
        {
            int animalsthatareremoved = 0;
            for (int i = 0; i < Animals.Count; i++)
            {
                Animal animal = Animals[i];


                if (animal.Species == species)
                {
                    Animals.Remove(animal);
                    animalsthatareremoved++;
                    i--;
                }
            }
            Capacity += animalsthatareremoved;
            return animalsthatareremoved;


        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return Animals.FindAll(animal => animal.Diet == diet);
        }
        public Animal GetAnimalByWeight(double weight)
        {

            return Animals.First(animal => animal.Weight == weight);
        }
        public string GetAnimalCountByLenght(double minimumLenght, double maximumLenght)
        {
            int count = Animals.Count(animal => animal.Lenght >= minimumLenght && animal.Lenght <= maximumLenght);
            return $"There are {count} animals with a length between {minimumLenght} and {maximumLenght} meters.";
        }
    }
    
}
