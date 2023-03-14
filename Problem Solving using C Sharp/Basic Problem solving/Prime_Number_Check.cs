using System;

namespace Program
{
    class Prime
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool flag=false;
            // i<=Math.Sqrt(n)
            for(int i = 2; i*i<=n; i++)
            {
                if (n%i==0)
                {
                    Console.WriteLine("Not Prime number");
                    flag = true;break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Prime number");
            }
        }
    }
}