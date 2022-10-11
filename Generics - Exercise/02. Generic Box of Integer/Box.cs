using System;
using System.Collections.Generic;
using System.Text;

namespace _02.BoxOfInteger
{
    public class Box<T>
    {
        public List<T> Items { get; set; }
        public Box()
        {
            Items = new List<T>();
        }
        public void Add(T item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.AppendLine($"System.Int32: {item}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
