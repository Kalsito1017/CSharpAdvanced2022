using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;
        public List<Person> FamilyMembers { get; set; }

        public Family()
        {
            this.FamilyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            FamilyMembers.Add(member);
        }

        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(member => member.Age).First();
        }
    }
}
