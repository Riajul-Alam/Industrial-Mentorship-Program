//https://www.interviewbit.com/problems/functions-in-c/
using System;
using System.IO;

class MAIN  {

    // declare the function here
    
    public static void Main(string[] args) {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int sum = addition(a, b);
        Console.WriteLine(sum);
    }
    private static int addition(int a,int b){
        return a+b;
    }
}