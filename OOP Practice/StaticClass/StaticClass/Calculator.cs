
using System;

namespace StaticClass
{
    internal class Calculator
    {
        public static double CalculateAverage(double[] nums)
        {
            var sum = 0.0;
            foreach(var x in nums){sum+=x;}
            return sum/nums.Length;
        }
    }
}






