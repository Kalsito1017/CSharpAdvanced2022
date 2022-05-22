using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string numberAsString = Console.ReadLine();
            Stack<int> numbers = new Stack<int>();
            string[] numbersList = numberAsString.Split(' ');  
            foreach (string number in numbersList)
            {
                numbers.Push(int.Parse(number));
            }
            while (true)
            {
                string line = Console.ReadLine();
                string[] lineParts = line.Split(' ');
                string command = lineParts[0].ToLower();
                if (command == "end")
                {
                    break;

                }
                else if(command == "add")
                {
                    // TODO: Add
                    numbers.Push(int.Parse(lineParts[1]));
                    numbers.Push(int.Parse(lineParts[2]));
                }
                else if (command == "remove")
                {
                    // TODO: Remove
                    var numberofElementsToRemove = int.Parse(lineParts[1]);
                    if (numberofElementsToRemove <= numbers.Count)
                    {
                        for (int i = 0; i < numberofElementsToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
            }
            int sum = 0;
            while (numbers.Count > 0)
            {
                int number = numbers.Pop();
                sum += number;

                
            }
            Console.WriteLine($"Sum: {sum}");
                
        }
    }
}
