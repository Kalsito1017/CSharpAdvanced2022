using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _04._Froggy
{
   
     class Lake : IEnumerable<int>
       {
        public int[] Path { get; set; }
        public Lake(int[] path)
        {
            this.Path = path;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int j = 0; j < Path.Length; j+=2)
            {
                yield return Path[j];
            }
            for (int i = Path.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return Path[i];
                }
                
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
     
    }
}
