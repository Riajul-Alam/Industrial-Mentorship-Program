using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public  class MethodOverloading
    {
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine(c);
        }
    }
}
