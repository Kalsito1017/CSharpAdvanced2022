using System;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        class CarManufacturer
        {

        }
        class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;
            public string WhoAmI()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Make: {this.Make}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Year: {this.Year}");
                sb.AppendLine($"Fuel: {this.FuelQuantity:F2}L");
                return sb.ToString();
            }


            public string Make { get => make; set => make = value; }
            public string Model { get => model; set => model = value; }
            public int Year { get => year; set => year = value; }
            public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
            public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
            public void Drive(double distance)
            {
                var consumption = distance * (FuelConsumption / 100.0);
                if (consumption <= FuelQuantity)
                {
                    fuelQuantity -= consumption;
                }
                else
                {
                    Console.WriteLine("Not enough fuel to perform this trip!");
                }
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelConsumption = 200;
            car.FuelQuantity = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
