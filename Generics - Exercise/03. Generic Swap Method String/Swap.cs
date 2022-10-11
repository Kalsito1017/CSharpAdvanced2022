using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Generic_Swap_Method_String
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
                sb.AppendLine($"System.String: {item}");
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
