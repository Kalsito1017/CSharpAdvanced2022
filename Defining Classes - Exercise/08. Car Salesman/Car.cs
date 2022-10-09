using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {

        }
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }
        public Car(string model, Engine engine, int weight) : this(model, engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight, string color) : this(model, engine)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {this.Engine.Model}:");
            sb.AppendLine($"    Power: {this.Engine.Power}");
            sb.AppendLine(this.Engine.Displacement != 0
                ? $"    Displacement: {this.Engine.Displacement}"
                : $"    Displacement: n/a");
            sb.AppendLine(this.Engine.Efficiency != null
                ? $"    Efficiency: {this.Engine.Efficiency}"
                : $"    Efficiency: n/a");
            sb.AppendLine(this.Weight != 0
                ? $"  Weight: {this.Weight}"
                : $"  Weight: n/a");
            sb.Append(this.Color != null
                ? $"  Color: {this.Color}"
                : $"  Color: n/a");

            return sb.ToString();
        }
    }
}