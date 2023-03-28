using System;


namespace Abstract_Class
{
    // if a class has abstract method ,then we use abstract class
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public Shape(string name){Name= name;}
        public void SetColor(string color){Color = color;}

        public abstract double CalculateArea();
    }
}




