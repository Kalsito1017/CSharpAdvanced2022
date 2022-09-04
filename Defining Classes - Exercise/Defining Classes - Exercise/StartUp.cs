using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           


            int count = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person currPerson = new Person(input[0], int.Parse(input[1]));

                persons.Add(currPerson);
            }

            List<Person> modifiedList = persons.OrderBy(person => person.Name).Where(person => person.Age > 30).ToList();

            foreach (Person person in modifiedList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }


        }
    }
}
