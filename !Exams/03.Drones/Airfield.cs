using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }
        public Airfield(string name, int capacity, double landingStrip)
        {
            Drones = new List<Drone>();
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
        }
        public int Count => Drones.Count;
        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range <= 5 || drone.Range >= 15)
            {
                return "Invalid drone.";
            }
            if (Capacity == 0)
            {
                return "Airfield is full.";
            }

            Drones.Add(drone);
            Capacity--;

            return $"Successfully added {drone.Name} to the airfield.";



        }
        public bool RemoveDrone(string name)
        {
            Drone drone = Drones.FirstOrDefault(x => x.Name == name);
            if (drone != default)
            {
                Capacity++;
                return Drones.Remove(drone);
            }
            return false;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = 0;
            for (int i = 0; i < Drones.Count; i++)
            {
                if (Drones[i].Brand == brand)
                {
                    count++;
                    Drones.Remove(Drones[i]);
                    i--;
                }
            }
            Capacity += count;
            return count;
        }
        public Drone FlyDrone(string name)
        {
            Drone drone = Drones.FirstOrDefault(s => s.Name == name);
            if (drone != default)
            {
                drone.Available = false;
                return drone;

            }
            else
            {
                return null;
            }
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = new List<Drone>();
            for (int i = 0; i < Drones.Count; i++)
            {
                if (Drones[i].Range == range)
                {
                    Drones[i].Available = false;
                    drones.Add(Drones[i]);
                }
            }
            return drones;

        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {this.Name}:");
            foreach (var drones in Drones.Where(drones => drones.Available == true))
            {
                sb.AppendLine(drones.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
