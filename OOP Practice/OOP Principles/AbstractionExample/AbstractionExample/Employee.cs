using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    class Employee
    {
        public int Id;
        public string Name;
        public double GrossPay;
        private double TaxDeduction = 0.1; // hide field
        private double netSalary;
        public Employee(int id, string name, double grosspay) 
        {
            Id=id;Name=name;GrossPay = grosspay;
        }
        private void CalculateSalary() //hiding implementation details 
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is: {0}", netSalary);
            }
            else{Console.WriteLine("Your Salary is: {0}", GrossPay);}
        }
        public void ShowEmployeeDetails()//display only essential features or functionalities
        { 
            Console.WriteLine("Employee Id is: {0}",Id);
            Console.WriteLine("Employee Name is: {0}",Name);
            CalculateSalary();
        }
    }
}
