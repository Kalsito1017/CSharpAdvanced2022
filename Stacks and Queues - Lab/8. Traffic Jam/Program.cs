using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            //Enzo's car
            //Jade's car
            //Mercedes CLS
            //Audi
            //green
            //BMW X5
            //green
            //end
            int numberofCarsToPassOnGreenLight = int.Parse(Console.ReadLine()); 
            Queue<string> cars = new Queue<string>();
            double passedCars = 0;  
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                else if (line == "green")
                {
                    for (int i = 0; i < numberofCarsToPassOnGreenLight; i++)
                    {
                        if (cars.Count > 0)
                        {
                            var car = cars.Dequeue();
                            Console.WriteLine(car + " passed!");
                            passedCars++;
                        }
                        
                    }
                }
                else 
                {
                    cars.Enqueue(line); //add car to the queue
                }
            }
            Console.WriteLine(passedCars + " cars passed the crossroads.");
        }
    }
}
