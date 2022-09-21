using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace CocktailParty
{
    public class Cocktail
    {
        public List<Ingredient> Ingredients { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new List<Ingredient>();
        }
        public void Add(Ingredient ingredient)
        {
            if (Ingredients.All(i => i.Name != ingredient.Name) && Capacity > 0 && MaxAlcoholLevel >= ingredient.Alcohol)
            {
                Ingredients.Add(ingredient);
            }
        }
        public bool Remove(string name)
        {
            
            if (Ingredients.Any(i => i.Name == name))
            {
                Ingredient ingredient = Ingredients.First(i => i.Name == name);
                return Ingredients.Remove(ingredient);
            }
            return false;
        }
        public Ingredient FindIngredient(string name) => Ingredients.FirstOrDefault(i => i.Name == name);
        public Ingredient GetMostAlcoholicIngredient() => Ingredients.OrderByDescending(i => i.Alcohol).First();
        public int CurrentAlcoholLevel => Ingredients.Sum(i => i.Alcohol);
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {this.Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
           
            foreach (var ingr in Ingredients)
            {
                sb.AppendLine(ingr.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
