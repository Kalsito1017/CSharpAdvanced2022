using System;

namespace CarManufacturer
{
    public class StartUp
    {
        
        class Car
        {
            private  string make;
            public string model;
            private string year;
            public string Make
            {
                get => make;
                set => make = value;

            }
            public string Model { get => model; set => model = value; }
            public string Year { get => year; set => year = value; }

        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Mk";
            car.Year = "1992";
            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
