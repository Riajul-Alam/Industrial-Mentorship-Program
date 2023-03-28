using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // internal class Member --> same project its behave like public but
    // different project we can't able to use it
    public class Member
    {
        private int Id { get; set; } // accessible inside class itself

        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        protected double Balance{get;set ; } // protected value we can access from child class

        protected internal string HashValue { get; set; } 
        public Member(int id)
        {
            Id=id;
            Balance=500;
        }

        // if we need to override method in child class then we used virtual keyword

        //public virtual GetAge

        /*        public int GetAge()
                {
                    return DateTime.Now.Year-DateOfBirth.Year;
                }
        */
        public virtual int GetAge()
        {
            return DateTime.Now.Year-DateOfBirth.Year;
        }

    }
}
