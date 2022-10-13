using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05._Comparing_Objects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
       
        public Person(string name, int age)
        { 
            Name = name;
            Age = age;
            
        }

        public int CompareTo( Person other)
        {
            int result = this.Name.CompareTo(other.Name);
            if (result == 0)
            {
                return this.Age.CompareTo(other.Age);
            }
            return result;
        }
        public override bool Equals(object? obj)
        {
            Person other = obj as Person;
            if (other == null)
            {
                return false;
            }
            return this.Name.Equals(other.Name) && this.Age.Equals(other.Age);
        }
        public override int GetHashCode() => HashCode.Combine(this.Name, this.Age);
        
    }
}
