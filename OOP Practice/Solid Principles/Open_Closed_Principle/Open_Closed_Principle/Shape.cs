using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
    }

    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double Area()
        {
            return _width * _height;
        }
    }

    public class Triangle : Shape
    {
        private double _base;
        private double _height;

        public Triangle(double @base, double height)
        {
            _base = @base;
            _height = height;
        }

        public override double Area()
        {
            return 0.5 * _base * _height;
        }
    }

}
