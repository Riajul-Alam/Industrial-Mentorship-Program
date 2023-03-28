using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    public struct myst
    {
        public string Name;
        public string Email;
        public int Age;
        // has Default constructor
        public myst(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Email);
            Console.WriteLine(Age);
        }
    }
}







