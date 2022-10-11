using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Generic_Count_Method_Double
{
    public class Counts<T> where T : IComparable
    {
        public List<T> List { get; set; }
        public Counts()
        {
            List = new List<T>();
        }
        public int Count(T itemtoCompare)
        {
            int count = 0;
            foreach (var item in List)
            {
                if (item.CompareTo(itemtoCompare) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
