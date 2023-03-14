using System;
namespace Program
{
    class MultiDimension
    {
        public static void Main(string[] args)
        {
            int[] ar=Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int n, m;
            n=ar[0]; m=ar[1];
            int[,] multi= new int[n,m];
            //Console.WriteLine(multi.GetLength(1));
            //Console.WriteLine(multi.Length)-->total number of element
            for(int i=0;i<multi.GetLength(0);i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                for(int j = 0; j<multi.GetLength(1); j++)
                {
                    multi[i,j] = input[j];
                }
            }
            for (int i = 0; i<multi.GetLength(0); i++)
            {
                for (int j = 0; j<multi.GetLength(1); j++)
                {
                    Console.Write(multi[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}