using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4 
                string[] inputCars = Console.ReadLine().Split();
                string name = inputCars[0];
                int engineSpeed = int.Parse(inputCars[1]);
                int enginePower = int.Parse(inputCars[2]);
                int cargoWeight = int.Parse(inputCars[3]);
                string cargoType = inputCars[4];
                List<Tire> tires = new List<Tire>();
                for (int indexTire =  5 ; indexTire <= 12; indexTire += 2)
                {
                    double tirePressure = double.Parse(inputCars[indexTire]);
                    int tireAge = int.Parse(inputCars[indexTire + 1]);
                    Tire tire = new Tire(tireAge, tirePressure);
                    tires.Add(tire);
                   
                }
                Engine engine = new Engine(engineSpeed, enginePower);  
                Cargo cargo = new Cargo(cargoType, cargoWeight);
                Car car = new Car(name, engine, cargo, tires);
                cars.Add(car);
            }
            string cargoTypes = Console.ReadLine();
            if (cargoTypes == "fragile")
            {
                List<Car> fragileCars = cars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(t => t.Pressure < 1)).ToList();
                foreach (var item in fragileCars)
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if (cargoTypes == "")
            {
                List<Car> flammableCars = cars.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power > 250).ToList();
                foreach (var item in flammableCars)
                {
                    Console.WriteLine(item.Model);
                }
            }
            

        }
    }
}
