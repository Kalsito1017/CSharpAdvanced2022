using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();   
            Queue<string> cars = new Queue<string>();
            int passedcars = 0;
            while (input != "END")
            {
                
                if (input != "green")
                {
                    cars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }
                int currentGreenLight = greenLight;
                // 5
                while (currentGreenLight > 0 && cars.Count > 0)
                {
                    // Golf - 4 
                    string currentCar = cars.Dequeue();
                    if (currentGreenLight - currentCar.Length >= 0)
                    {
                        currentGreenLight -= currentCar.Length;
                        passedcars++;
                        continue;
                    }
                    if (currentGreenLight + freeWindow - currentCar.Length >= 0)
                    {
                        currentGreenLight = 0;
                        passedcars++;
                        continue;
                    }
                    //Hummer
                    //1 + 3 = 4
                     int hitterChar = currentGreenLight + freeWindow;


                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currentCar} was hit at {currentCar[hitterChar]}.");
                    Environment.Exit(0);

                }
                input = Console.ReadLine();
                //car pass - no time left
                // car pass - time left
                // car pass - time left + free window
                //crash
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedcars} total cars passed the crossroads.");


        }
    }
}
