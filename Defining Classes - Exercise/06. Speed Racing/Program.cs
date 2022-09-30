using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);

                Car currCar = new Car(model, fuelAmount, fuelConsumptionFor1km);
                cars.Add(currCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] driveArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = driveArgs[1];
                int distance = int.Parse(driveArgs[2]);
                Car currCar = cars.First(car => car.Model == model);

                Car.Drive(currCar, distance);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
