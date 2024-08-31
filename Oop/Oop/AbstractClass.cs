using System;


namespace Oop
{
    public abstract class AbstractClass
    {
        public double Height {  get; set; }
        public double Width { get; set; }
        public double Radius { get; set; }
        public const double PI = 3.14;

        public abstract double getArea();
    }
    public class Rectangle:AbstractClass
    {
        public Rectangle(double height, double width) { this.Width = width; this.Height = height; }

        public override double getArea()
        {
            return this.Width * this.Height;
        }
    }
    public class Circle : AbstractClass
    {
        public Circle(double radius) { this.Radius = radius; }
        public override double getArea() { return this.Radius * (PI * PI); }

    }
    
}
