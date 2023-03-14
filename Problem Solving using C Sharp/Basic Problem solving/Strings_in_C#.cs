//https://www.interviewbit.com/problems/strings-in-c/
using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        String str = Console.ReadLine();
        
        // Print the length of the string
        Console.WriteLine(str.Length);
        
        // Print the first index of the character 'a' in the string
        // If none present, print -1
        int c2=0;
        for(int i=0;i<str.Length;i++){
            if(str[i]=='a'){
                Console.WriteLine(i);c2++;break;
            }
        }
        if(c2==0){
            Console.WriteLine("-1");
        }
        
        // Print the number of occurrences of the character 'b' in the string
        int c1=0;
        for(int i=0;i<str.Length;i++){
            if(str[i]=='b')c1++;
        }
        Console.WriteLine(c1);
        
        // Print the substring from the 1st index to the 4th index (inclusive)
        string tmp=str.Substring(2,3);
        Console.WriteLine(tmp);
        
        // Check if the string is equal to "InterviewBit"
        // Print the resulting boolean
        if(str=="InterviewBit"){
            Console.WriteLine("True");
        }
        else{
            Console.WriteLine("False");
        }
    }
}