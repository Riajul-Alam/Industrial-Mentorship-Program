

// this Code gives error
/*using System;

namespace Tutlane
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            // Complier Error
            // These are inaccessible due to protected specifier
            u.Name = "Suresh Dasari";
            u.Location = "Hyderabad";
            u.Age = 32;
            u.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
*/

using System;

namespace Tutlane
{
    class User
    {
        protected string Name;
        protected string Location;
        protected int Age;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program : User
    {
        static void Main(string[] args)
        {
            User u = new User();
            Program p = new Program();
            // Complier Error
            // protected members can only accessible with derived classes
            //u.Name = "Riajul Alam";
            p.Name ="Riajul Alam";
            p.Location ="Bangladesh";
            p.Age = 50;
            p.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}