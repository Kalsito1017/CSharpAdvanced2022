using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Special_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputTires = Console.ReadLine();
            List<List<Tire>> tiresList = new List<List<Tire>>();
            List<Tire> tires = new List<Tire>();
            while (inputTires != "No more tires")
            {
                string[] placeholders = inputTires.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int yearTireOne = int.Parse(placeholders[0]);
                double pressureTireOne = double.Parse(placeholders[1]);
                int yearTireTwo = int.Parse(placeholders[2]);
                double pressureTireTwo = double.Parse(placeholders[3]);
                int yearTireThree = int.Parse(placeholders[4]);
                double pressureTireThree = double.Parse(placeholders[5]);
                int yearTireFour = int.Parse(placeholders[6]);
                double pressureTireFour = double.Parse(placeholders[7]);

                tires.Add(new Tire(yearTireOne, pressureTireOne));
                tires.Add(new Tire(yearTireTwo, pressureTireTwo));
                tires.Add(new Tire(yearTireThree, pressureTireThree));
                tires.Add(new Tire(yearTireFour, pressureTireFour));
                var list = new List<Tire>(tires);
                tiresList.Add(list);
                tires.Clear();
                inputTires = Console.ReadLine();
            }

            string inputEngine = Console.ReadLine();
            List<Engine> engines = new List<Engine>();
            while (inputEngine != "Engines done")
            {
                string[] placeholders = inputEngine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int horsePower = int.Parse(placeholders[0]);
                double cubicCapacity = double.Parse(placeholders[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
                inputEngine = Console.ReadLine();
            }

            string carsFormat = Console.ReadLine();
            List<Car> catalog = new List<Car>();
            while (carsFormat != "Show special")
            {
                string[] placeHolders = carsFormat.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string make = placeHolders[0];
                string model = placeHolders[1];
                int year = int.Parse(placeHolders[2]);
                double fuelQuantity = double.Parse(placeHolders[3]);
                double fuelConsumption = double.Parse(placeHolders[4]);
                int engineIndex = int.Parse(placeHolders[5]);
                int tiresIndex = int.Parse(placeHolders[6]);

                catalog.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tiresList[tiresIndex]));
                carsFormat = Console.ReadLine();
            }

            List<Car> specialCars = catalog.Where(car =>
                    car.Year >= 2017 &&
                    car.Engine.HorsePower > 330 &&
                    car.Tires.Sum(x => x.Pressure) >= 9 &&
                    car.Tires.Sum(x => x.Pressure) <= 10)
                .ToList();

            foreach (var car in specialCars)
            {
                car.Drive(20);

                Console.WriteLine(car.WhoAmI());
            }//replace List<Tire> with tire array
        }
    }
}
