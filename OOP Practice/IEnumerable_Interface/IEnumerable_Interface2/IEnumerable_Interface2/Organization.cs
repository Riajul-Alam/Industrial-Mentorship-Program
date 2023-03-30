using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Interface2
{
    public class Organization : IEnumerable
    {
        List<Employee> Emps = new List<Employee>();
        public void Add(Employee emp)
        {
            Emps.Add(emp);
        }
        public int Count { get { return Emps.Count; } }

        public Employee this[int index]
        {
            get { return Emps[index]; }
        }
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }
    }
}
