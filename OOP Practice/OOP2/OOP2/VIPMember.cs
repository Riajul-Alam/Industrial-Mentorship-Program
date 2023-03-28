using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class VIPMember:Member
    {
        // using constructor chaining
        // we can't use base class private member , but we can use it through public method,property

        public VIPMember(int id) : base(id)
        {
            Balance=100; // protected value we can access from child class
            HashValue="ABBCDE";  
        }
        public override int GetAge()
        {
            return DateTime.Now.Subtract(DateOfBirth).Days/365;
        }
    }
}
