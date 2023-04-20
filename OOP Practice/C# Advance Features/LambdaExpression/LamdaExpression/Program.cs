using System;
using System.IO;
using System.Collections.Generic;
using LamdaExpression;


Func<int, int, int> add = (x, y) => x + y;

// Call the lambda expression
int result = add(2, 3); // result = 5
Console.WriteLine(result);



// Create a list of Person objects
List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 30 },
    new Person { Name = "Bob", Age = 25 },
    new Person { Name = "Charlie", Age = 35 }
};

// Sort the list of people by age using a lambda expression
people.Sort((person1, person2) => person1.Age.CompareTo(person2.Age));

// Print the sorted list
foreach (Person person in people)
{
    Console.WriteLine("{0} ({1})", person.Name, person.Age);
}



