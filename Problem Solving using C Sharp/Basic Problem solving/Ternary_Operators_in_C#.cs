//https://www.interviewbit.com/problems/ternary-operators-in-c/
using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        
        // Use Ternary operator to find and print the maximum number
        // out of a, b and c
        int ans=a>b?a:b;
        ans=ans>c?ans:c;
        Console.WriteLine(ans);
        
    }
}