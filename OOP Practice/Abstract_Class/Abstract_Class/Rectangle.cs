using System;

namespace Abstract_Class
{
    public class Rectangle : Shape
    {
        public double Width { get; private set; }
        public double Height { get; private set; }
        public Rectangle(double width,double height,string name):base(name)
        {
            Width=width;
            Height=height;
        }
        public override double CalculateArea(){return Height*Width;} 
    }
}





