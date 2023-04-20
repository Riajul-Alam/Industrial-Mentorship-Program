using System;
using DelegatesExample;

Delegates ob=new Delegates();
// Create delegates that reference the Add and Subtract methods
MathOperation addDelegate = new MathOperation(ob.Add);
MathOperation subtractDelegate = new MathOperation(ob.Subtract);

// Call the Add and Subtract methods indirectly through the delegates
int sum = addDelegate(2, 3);
int difference = subtractDelegate(5, 2);

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);






