using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiRental
{
    public class SkiRental
    {
        public List<Ski> Data { get; set; }
        public string Name { get; set; }
        public int Capactity { get; set; }
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capactity = capacity;
            Data = new List<Ski>();
        }
        public int Count => Data.Count;
        public void Add(Ski ski)
        {
            if (Count < Capactity)
            {
                Data.Add(ski);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            if (Data.Any(s => s.Manufacturer == manufacturer && s.Model == model))
            {
                Ski ski = Data.First(s => s.Manufacturer == manufacturer && s.Model == model);
                return Data.Remove(ski);
            }
            return false;
        }
        public Ski GetNewestSki() => Data.OrderByDescending(s => s.Year).FirstOrDefault();

        public Ski GetSki(string manufacturer, string model) =>
        Data.FirstOrDefault(s => s.Manufacturer == manufacturer && s.Model == model);
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");

            foreach (var ski in Data)
            {
                sb.AppendLine(ski.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
