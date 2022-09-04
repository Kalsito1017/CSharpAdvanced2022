using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person()
        {
            this.Name = "No Name";
            Age = 1;
        }
        public Person(int age)
        {
            Name = "No Name";
            this.Age = age;
        }
        public Person(string name, int age)
        {
            Name = name;
            this.Age = age;
        }
        public List<Person> People { get; set; }
        public void AddMember(Person person)
        {
            People.Add(person);
        }
        public Person GetOldestMembers()
        {
            Person oldestMembers = People.OrderByDescending(x => x.Age)
            .FirstOrDefault();
            return oldestMembers;
        }
    }
}
