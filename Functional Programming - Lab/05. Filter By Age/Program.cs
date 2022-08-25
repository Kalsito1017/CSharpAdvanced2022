using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    internal class Program
    {
        class Person
        {
            
            public string Name;
            public int Age;
        }
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int integer = int.Parse(Console.ReadLine());
            for (int i = 0; i < integer; i++)
            {
                string line = Console.ReadLine();
                var argss = line.Split(", ");
                var person = new Person();
                person.Name = argss[0];
                person.Age = int.Parse(argss[1]);
                people.Add(person);

            }
            var filterName = Console.ReadLine(); // younger/older/ exact
            int age = int.Parse(Console.ReadLine());
            Func<Person, bool> filter = p => true;
            if (filterName == "younger")
            {
                filter = p => p.Age < age; 
            }
            else if (filterName == "older")
            {
                filter = p => p.Age >= age
                ;
            }
            var filteredPeople = people.Where(filter);
            //foreach (var person in filteredPeople)
            //{
            //    Console.WriteLine(person.Name + " - " + person.Age);
            //}
            var printName = Console.ReadLine();
            Func<Person, string>printFunc= p => p.Name + " " + p.Age;
            if (printName == "name age")
            {
                printFunc = p => p.Name + " - " + p.Age;
            }
            else if (printName == "age")
            {
                printFunc = p => p.Age.ToString();
            }
            else if (printName == "name")
            {
                printFunc = p => p.Name;
            }
            var personAsString = filteredPeople.Select(printFunc);
            foreach (var item in personAsString)
            {
                Console.WriteLine(item);
            }

        }
    }
}
