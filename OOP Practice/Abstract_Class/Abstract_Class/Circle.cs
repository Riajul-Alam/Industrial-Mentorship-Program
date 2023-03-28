using System;

namespace Abstract_Class
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius, string name) : base(name)
        {
            Radius=radius;
        }
        public override double CalculateArea()
        {
            return Math.PI*Radius*Radius;
        }
    }
}







