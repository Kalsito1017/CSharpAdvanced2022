using System;
using System.Collections.Generic;
using System.Linq;

namespace Cars
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> engines = GetTheEngines();

            List<Car> cars = GetTheCars(engines);

            cars.ForEach(car => Console.WriteLine(car.ToString()));
        }

        private static List<Car> GetTheCars(List<Engine> engines)
        {
            List<Car> cars = new List<Car>();

            int countOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                string engineModel = carInfo[1];

                Engine engine = engines.First(engine => engine.Model == engineModel);

                Car car = new Car();

                if (carInfo.Length == 4)
                {
                    int weight = int.Parse(carInfo[2]);
                    string color = carInfo[3];
                    car = new Car(model, engine, weight, color);
                }
                else if (carInfo.Length == 3)
                {
                    string input = carInfo[2];

                    bool isNumber = int.TryParse(input, out int number);

                    if (isNumber)
                    {
                        int weight = int.Parse(carInfo[2]);
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        string color = carInfo[2];
                        car = new Car(model, engine, color);
                    }
                }
                else if (carInfo.Length == 2)
                {
                    car = new Car(model, engine);
                }

                cars.Add(car);
            }

            return cars;
        }

        private static List<Engine> GetTheEngines()
        {
            List<Engine> engines = new List<Engine>();

            int countOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = engineInfo[0];
                int power = int.Parse(engineInfo[1]);

                Engine engine = new Engine();

                if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    string efficiency = engineInfo[3];
                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineInfo.Length == 3)
                {
                    string input = engineInfo[2];

                    bool isNumber = int.TryParse(input, out int number);

                    if (isNumber)
                    {
                        int displacement = int.Parse(engineInfo[2]);
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        string efficiency = engineInfo[2];
                        engine = new Engine(model, power, efficiency);
                    }
                }
                else if (engineInfo.Length == 2)
                {
                    engine = new Engine(model, power);
                }

                engines.Add(engine);
            }

            return engines;
        }
    }
}
