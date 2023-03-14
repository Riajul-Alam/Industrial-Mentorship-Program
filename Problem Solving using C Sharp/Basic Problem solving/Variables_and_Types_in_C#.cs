//https://www.interviewbit.com/problems/variables-and-types-in-c/
using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        string userInput ;
        userInput=Console.ReadLine();
        int a=Convert.ToInt32(userInput);
        Console.WriteLine(a);
        userInput=Console.ReadLine();
        long b=Convert.ToInt64(userInput);
        Console.WriteLine(b);
        userInput=Console.ReadLine();
        char ch;
        ch=Convert.ToChar(userInput);
        Console.WriteLine(ch);
        // bool Flag;
        // userInput=Console.ReadLine();
        // Flag=Convert.ToBool(userInput);
        //Console.WriteLine(Flag);
        userInput=Console.ReadLine();
        float c=Convert.ToSingle(userInput);
        Console.WriteLine(c);
        double d;
        userInput=Console.ReadLine();
        d=Convert.ToDouble(userInput);
        Console.WriteLine(d);
    }
}