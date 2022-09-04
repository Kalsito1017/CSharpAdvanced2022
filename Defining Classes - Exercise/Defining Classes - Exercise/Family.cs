using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    internal class Family
    {
        public Family()
        {
            People = new List<Person>();
        }
        public List<Person> People { get; set; }
        public void AddMember(Person person)
        {
            People.Add(person);
            var trueperson = People.OrderBy(x => x);
            
        }
        public Person GetOldestMembers()
        {
            Person oldestMembers = People.OrderBy(x => x).FirstOrDefault();
            
            return oldestMembers;
        }
    }
}
