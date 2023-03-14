using System;
namespace Program
{
    class myApp
    {
        public static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            //int[] a=Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int[] a=new int[n];
            a=Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            Array.Reverse(a);
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }Console.WriteLine();
        }
    }
}