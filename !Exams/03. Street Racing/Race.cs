using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StreetRacing
{
    public class Race
    {
        public List<Car> Participants { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            Participants = new List<Car>();
            Name = name;
            Type = type;
            Laps = laps;
            Capacity = capacity;
            MaxHorsePower = maxHorsePower;
        }
        public int Count => Participants.Count; 
        public void Add(Car car)
        {
            if (Participants.Any(s => s.LicensePlate == car.LicensePlate) == false && Capacity > Count && car.HorsePower <= MaxHorsePower)
            {
                Participants.Add(car);
            }
        }
        public bool Remove(string licenseplate)
        {
            if (Participants.Any(s => s.LicensePlate == licenseplate))
            {
                Participants.Remove(Participants.First(s => s.LicensePlate == licenseplate));
                return true;
            }
            return false;
        }
        public Car FindParticipant(string licensePlate)
        {
            return Participants.FirstOrDefault(s => s.LicensePlate == licensePlate);
            
        }
        public Car GetMostPowerfulCar()
        {
            return Participants.OrderByDescending(c => c.HorsePower).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps})");
            foreach (var car in Participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
