using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";
            HashSet<char> pearSet = new HashSet<char>(pear.ToCharArray());
            HashSet<char> flourSet = new HashSet<char>(pear.ToCharArray());
            HashSet<char> porkSet = new HashSet<char>(pear.ToCharArray());
            HashSet<char> oliveSet = new HashSet<char>(pear.ToCharArray());
            List<char> volews = Console.ReadLine()?.Split("").Select(char.Parse).ToList();
            List<char> consonants = Console.ReadLine()?.Split("").Select(char.Parse).ToList();
            foreach (var volew in volews)
            {
                if (pearSet.Contains(volew))
                {
                    pearSet.Remove(volew);
                }
                if (porkSet.Contains(volew))
                {
                    porkSet.Remove(volew);
                }
                if (flourSet.Contains(volew))
                {
                    flourSet.Remove(volew);
                }
                if (oliveSet.Contains(volew))
                {
                    oliveSet.Remove(volew);
                }

            }
            bool IsRemoved = false;
            foreach (var consonant in consonants.ToList())
            {
                IsRemoved = false;
                if (pearSet.Contains(consonant))
                {
                    pearSet.Remove(consonant);
                    IsRemoved = true;
                }
                if (porkSet.Contains(consonant))
                {
                    porkSet.Remove(consonant);
                    IsRemoved = true;
                }
                if (flourSet.Contains(consonant))
                {
                    flourSet.Remove(consonant);
                    IsRemoved = true;
                }
                if (oliveSet.Contains(consonant))
                {
                    oliveSet.Remove(consonant);
                    IsRemoved = true;
                }
            }
            List<string> list = new List<string>();
            if (!pearSet.Any())
            {
                list.Add(pear);
            }
            if (!porkSet.Any())
            {
                list.Add(pork);
            }
            if (!oliveSet.Any())
            {
                list.Add(olive);
            }
            if (!flourSet.Any())
            {
                list.Add(flour);
            }
            foreach (var item in collection)
            {

            }
        }
    }
}
