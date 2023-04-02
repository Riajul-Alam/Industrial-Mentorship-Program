using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class OperatorOverloading
    {
        public string Name;
        public int Age;
        public static OperatorOverloading operator + (OperatorOverloading ob1, OperatorOverloading ob2)
        {
            OperatorOverloading ob3 = new();
            ob3.Name = ob1.Name+" "+ob2.Name;
            ob3.Age = ob1.Age+ob2.Age;
            return ob3;
        }
    }
}



