using System;

namespace CarManufacturer
{
    public class StartUp
    {
        class Car

        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;

            public Car()
            {

            }

            public Car(string make, string model, int year)
            {
                this.make = make;
                this.model = model;
                this.year = year;
            }
            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
            {
                this.fuelQuantity = fuelQuantity;
                this.fuelConsumption = fuelConsumption;
            }
        }


        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car firstcar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

        }
    }
}
