using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Generic_Swap_Method_Integer
{
    public class Swap<T>
    {
        public List<T> Values { get; set; }
        public Swap()
        {
            Values = new List<T>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Values)
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            return sb.ToString().TrimEnd();
        }
       public void Swaps(int firstIndex, int SecondIndex)
        {
            T temp = Values[firstIndex];
            Values[firstIndex] = Values[SecondIndex];
            Values[SecondIndex] = temp;
        }
    }
}
