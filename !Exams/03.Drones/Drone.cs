using System;
using System.Collections.Generic;
using System.Text;

namespace Drones
{
    public class Drone
    {
        private string name;
        private string brand;
        private int range;
        private bool available = true;

        public string Name { get; set; }
        public string Brand { get; set; }
        public int Range { get; set; }
        public bool Available { get; set; }
        public Drone(string name, string brand, int range)
        {
            this.Name = name;
            this.Brand = brand;
            this.Range = range;
            this.Available = available;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drone: {Name}");
            sb.AppendLine($"Manufactured by: {Brand}");
            sb.AppendLine($"Range: {Range} kilometers");
            return sb.ToString();
        }
    }
}
