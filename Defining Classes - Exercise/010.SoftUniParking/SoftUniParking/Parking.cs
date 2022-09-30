using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        public List<Car> cars;
        

        public int Capacity { get; set; }
        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        public int Count => Cars.Count;
        public Parking(int capacity)
        {
            this.Capacity = capacity;
            this.Cars = new List<Car>();
        }
        public string AddCar(Car car)
        {
            if (Cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (Cars.Count > Cars.Capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return "Successfully added new car {Make} {RegistrationNumber}";
        }
        public string RemoveCar(string RegistrationNumber)
        {
            bool isInList = Cars.Any(car => car.RegistrationNumber == RegistrationNumber);
            if (isInList)
            {
                cars.RemoveAll(car => car.RegistrationNumber == RegistrationNumber);
                
                Capacity++;
                return $"Successfully removed {RegistrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return Cars.First(c => c.RegistrationNumber == registrationNumber);
        }
        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string regNum in registrationNumbers)
            {
                RemoveCar(regNum);
            }
        }

    }
}
