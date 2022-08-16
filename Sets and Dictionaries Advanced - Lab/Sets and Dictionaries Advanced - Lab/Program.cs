using System;
using System.Collections.Generic;
using System.Numerics;

namespace Sets_and_Dictionaries_Advanced___Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////random things
            ////HashSet<string> set = new HashSet<string>();
            //var dic = new Dictionary<string, int>();
            //dic.Add("hehehah", 150);
            //if (dic.ContainsValue(150))
            //{
            //    Console.WriteLine(dic.ContainsValue(150));
            //}
            //Vector3 v = new Vector3();
            HashSet<string> set = new HashSet<string>();
            //Niki
            set.Add("Niki");
            set.Add("Kalsito1017");
           if (set.Contains("Niki"))
            {
                
            }
            set.Remove("Niki");
            set.EnsureCapacity(3);
            //SortedSet<int> set2 = new SortedSet<int>();
            
                
        }
    }
}
