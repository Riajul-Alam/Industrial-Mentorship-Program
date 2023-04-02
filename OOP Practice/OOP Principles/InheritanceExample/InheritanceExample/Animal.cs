using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Animal
    {
        public Animal(){Console.WriteLine("The animal is eating.");}
        public virtual void MakeSound(){Console.WriteLine("The animal makes a sound");}
    }
    public class Dog : Animal
    {
        public override void MakeSound() { Console.WriteLine("The dog barks"); }
    }

    public class Cat : Animal
    {
        public override void MakeSound() { Console.WriteLine("The cat meows"); }
    }
}





