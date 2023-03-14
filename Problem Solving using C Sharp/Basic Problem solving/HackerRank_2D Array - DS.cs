using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static int hourglassSum(List<List<int>> arr)
    {
        int ans=-100;
        int n,m;n=arr.Count;m=arr[0].Count;
        for(int i=0;i+2<n;i++){
            int sum=0,c1=0;
            for(int j=0;j+2<m;j++){
                sum+=arr[i][j];sum+=arr[i][j+1];sum+=arr[i][j+2];
                sum+=arr[i+1][j+1];
                sum+=arr[i+2][j];sum+=arr[i+2][j+1];sum+=arr[i+2][j+2];c1++;
                ans=Math.Max(sum,ans);sum=0;
            }
        }
        return ans;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < 6; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.hourglassSum(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
