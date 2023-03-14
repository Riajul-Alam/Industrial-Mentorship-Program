using System;

namespace Program
{
    class Prime
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool flag=false;
            if(n<2) flag=true;
            // i<=Math.Sqrt(n)
            for(int i = 2; i*i<=n; i++)
            {
                if (n%i==0)
                {
                    flag = true;break;
                }
            }
            if (!flag)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not Prime number");
            }
        }
    }
}