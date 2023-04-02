using AbstractionExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Employee emp= new Employee(333, "Riajul Alam", 60000);
        emp.ShowEmployeeDetails();
        Console.ReadKey();
    }
}




