using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask_01
{

    public class Pair<T, Q>
    {
        // 2 properties
        public T First { get; set; }
        public T Second { get; set; }

        // Constructor initialization
        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }
    }
}







