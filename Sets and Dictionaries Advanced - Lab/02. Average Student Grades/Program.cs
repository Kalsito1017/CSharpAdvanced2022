using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < line; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                double grade = double.Parse(input[1]);
                if (students.ContainsKey(name) == false)
                {
                    students.Add(name, new List<double>());
                }
                students[name].Add(grade);

            }
            foreach (var item in students)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"avg: {item.Value.Average():F2}");
                Console.WriteLine();
            }
        }
    }
}
