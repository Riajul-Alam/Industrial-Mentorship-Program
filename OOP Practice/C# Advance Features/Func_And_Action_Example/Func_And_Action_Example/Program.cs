

int Add(int a, int b)
{
    return a + b;
}

Func<int, int, int> addFunc = Add;
Console.WriteLine(addFunc(2, 3));



static void PrintString(string s)
{
    Console.WriteLine(s);
}

// Define an Action delegate that takes a single string parameter
Action<string> printAction = PrintString;

// Call the delegate with a string parameter
printAction("Hello, world!");



