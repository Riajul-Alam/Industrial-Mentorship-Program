using System;
namespace Program
{
    class JaggedArray1
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];
            for(int i=0;i < n;i++) {
                jaggedArray[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            }
            for(int i=0;i<jaggedArray.Length;i++)
            {
                for(int j=0;j< jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+ " ");
                }Console.WriteLine();
            }

        }
    }
}