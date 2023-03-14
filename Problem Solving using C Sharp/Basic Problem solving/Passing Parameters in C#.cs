//https://www.interviewbit.com/problems/passing-parameters-in-c/
using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        int val = Convert.ToInt32(Console.ReadLine());
        int a = 0, b = 0;
        func1(val);
        a = val;        // stores the value of val after calling func1
        func2(ref val);
        b = val;        // stores the value of val after calling func2
        if(a==b){
            Console.WriteLine("True");
        }else{
            Console.WriteLine("False");
        }
        // Compare the values of a and b
        
        
    }
    private static int func1(int a){
        a=2;
        return a;
    }
    private static int func2(ref int a){
        a=2;
        return a;
    }
    
}