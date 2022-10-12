using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03._Stack
{
    public class ListyIterator<T> : IEnumerable<T>
    {
       
        public T[] array;
        public List<T> Stack;
        public ListyIterator(params T[] arr)
        {
            
            Stack = new List<T>(arr);
            
        }
        public void Push (params T[] element)
        {
            foreach (var param in element)
            {
                Stack.Insert(Stack.Count, param);
            }
        }
        public T Pop()
        {
            if (Stack.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            T popped = Stack[Stack.Count - 1];
            Stack.RemoveAt(Stack.Count - 1);
            return popped;
        }
        
       

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = Stack.Count - 1; i >= 0; i--)
            {
                yield return Stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
