using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public string Model { get { return model; } set { model = value; } }
        public string Efficiency { get { return efficiency; } set { efficiency = value; } }
        public int Power { get { return power; } set { power = value; } }
        public int Displacement { get { return displacement; } set { displacement = value; } }

        public Engine()
        {
            
        }
        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }
        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            this.Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }
    }
}