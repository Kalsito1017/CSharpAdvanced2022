using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person currPerson = new Person(input[0], int.Parse(input[1]));

                family.AddMember(currPerson);
            }

            Person eldestPerson = family.GetOldestMember();

            Console.WriteLine($"{eldestPerson.Name} {eldestPerson.Age}");
        }
    }
}

