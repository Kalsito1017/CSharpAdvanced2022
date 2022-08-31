using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(1, 2.1),
                new Tire(2, 0.5),
                new Tire(2, 2.3),

            };
            var engine = new Engine(560, 6300);
            var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
        }
        class Car

        {
            string make;

            string model;

            int year;

            double fuelQuantity;

            double fuelConsumption;

            Engine engine;

            Tire[] tire;




            public Car()
            {

                Make = "VW";
                Model = "Golf";
                Year = 2025;
                FuelQuantity = 200;
                FuelConsumption = 10;
            }
            public Car(string make, string model, int year) : this()
            {
                this.Make = make; // bmw
                this.Model = model;//x6
                this.Year = Year;//2019
            }
            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
            {
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumption = fuelConsumption;
            }
            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tire) : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                this.Engine = engine;
                this.Tire = tire;
            }






            public string Make { get { return this.make; } set { make = value; } }

            public string Model { get { return this.model; } set { model = value; } }

            public int Year { get { return this.year; } set { year = value; } }

            public double FuelQuantity { get { return this.fuelQuantity; } set { fuelQuantity = value; } }

            public double FuelConsumption { get { return this.fuelConsumption; } set { fuelConsumption = value; } }

            public Engine Engine { get { return this.engine; } set { engine = value; } }

            public Tire[] Tire { get { return this.tire; } set { this.tire = value; } }
          
         

        }
        class Engine
        {
            int hoursePower;

            double cubicCapacity;

            public Engine()
            {

            }
            public Engine(int hoursepower, double cubiccapacity)
            {
                this.HoursePower = hoursepower;
                this.CubicCapacity = cubiccapacity;
            }

            public int HoursePower { get { return this.hoursePower; } set { hoursePower = value; } }
            public double CubicCapacity { get { return this.cubicCapacity; } set { cubicCapacity = value; } }
        }
        public class Tire
        {
            int year;
            double pressure;

            public Tire()
            {

            }
            public Tire(int year, double pressure)
            {
                this.Year = year;
                this.Pressure = pressure;
            }

            public int Year { get { return this.year; } set { year = value; } }

            public double Pressure { get { return this.pressure; } set { pressure = value; } }

        }

    }
        
    
}
