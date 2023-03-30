using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Interface2
{
    public  class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job {  get; set; }
        public double Salary { get; set; }
        public Employee(int id, string name, string job, double salary)
        {
            Id=id;
            Name=name;
            Job=job;
            Salary=salary;
        }
    }
}
