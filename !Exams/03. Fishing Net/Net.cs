using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        public List<Fish> Fish { get; set; }
        public string Material { get; set; }
        public int Capacity { get; set; }
        public Net( string material, int capacity)
        {
            Fish = new List<Fish>();
            Material = material;
            Capacity = capacity;
        }
        public int Count => Fish.Count;
        public string AddFish(Fish fish)
        {
          
            if (fish.FishType == null || fish.FishType == " ")
            {
                return "Invalid fish.";
            }
            if (fish.Lenght <= 0 || fish.Weight <= 0)
            {
                return "Invalid fish.";
            }
            if (Capacity == 0)
            {
                return "Fishing net is full.";
            }
            Fish.Add(fish);
            Capacity--;
            return $"Successfully added {fish.FishType} to the fishing net.";
        }
        public bool ReleaseFish(double weight)
        {
            if (Fish.Any(s => s.Weight == weight))
            {
                Fish fish = Fish.First(fish => fish.Weight == weight);
                return Fish.Remove(fish);
            }
            return false;
        }
        public Fish GetFish(string fishType)
        {
            return Fish.FirstOrDefault(fish => fish.FishType == fishType);
        }
        public Fish GetBiggestFish()
        {
            return Fish.OrderByDescending(fish => fish.Weight).FirstOrDefault();
        }
        public string Report()

        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Into the {Material}:");
            foreach (var fish in Fish.OrderByDescending(f => f.Lenght))
            {
                sb.AppendLine(fish.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        
    }
}
