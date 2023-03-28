using System;

namespace virtual_keyword
{
    // if we need to override method in child class then
    // we used virtual keyword
    public class Car : Vehicle
    {
        public override void ChangeSpeed(double speed)
        {
            Speed=speed;
            Console.WriteLine("Current Speed : "+Speed);
        }
    }
}



