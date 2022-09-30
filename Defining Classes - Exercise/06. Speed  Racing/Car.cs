using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Car
        
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public static void Drive(Car car, int distance)
        {
            if (distance * car.FuelConsumptionPerKilometer > car.FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                car.FuelAmount -= distance * car.FuelConsumptionPerKilometer;
                car.TravelledDistance += distance;
            }
        }





    }
}
