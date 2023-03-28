using System;

namespace virtual_keyword
{
    public class Vehicle
    {
        public double Speed;
        public virtual void ChangeSpeed(double speed)
        {
            Speed=speed;
            Console.WriteLine("Speed : "+Speed);
        }
    }
}



