using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheRace;

namespace TheRace
{
    public class Race
    {
        public List<Racer> Data { get; set; }
        public string Name { get; set; }    
        public int Capacity { get; set; }
        public Race(string name, int capacity)
        {
            Data = new List<Racer>();
            Name = name;
            Capacity = capacity;
        }
        public int Count => Data.Count;
        public void Add(Racer Racer)
        {
            if (Count < Capacity)
            {
                Data.Add(Racer);
            }
        }
        public bool Remove(string name)
        {
            if (Data.Any(s => s.Name == name))
            {
                Racer racer = Data.FirstOrDefault(s => s.Name == name);
                return Data.Remove(racer);
            }
            return false;
        }
        public Racer GetOldestRacer()
        {
            return Data.OrderByDescending(s => s.Age).FirstOrDefault();
        }
        public Racer GetRacer(string name)
        {
            return Data.FirstOrDefault(s => s.Name == name);
        }
        public Racer GetFastestRacer()
        {
            return Data.OrderByDescending(r => r.Car.Speed).First();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in Data)
            {
                sb.AppendLine(racer.ToString());
            }
            return sb.ToString().Trim();
        }
        
    }
}
