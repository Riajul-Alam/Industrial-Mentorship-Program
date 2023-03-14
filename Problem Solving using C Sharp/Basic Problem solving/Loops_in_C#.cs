//https://www.interviewbit.com/problems/loops-in-c/
using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {

        // Find the factorial of num1 and print it in a separate line
        int num1 = Convert.ToInt32(Console.ReadLine());
        long ans=1;
        for(int i=1;i<=num1;i++){
            ans*=i;
        }
        Console.WriteLine(ans);
        
        // Find the highest power of 2 that divides num2
        // and print it in a separate line        
    
        int num2 =  Convert.ToInt32(Console.ReadLine());
        long a=1;ans=0;
        for(int i=0;num2>=a;i++){
            if(num2%a==0){
                ans=i;
            }a*=2;
        }
        Console.WriteLine(ans);
      
    }
}