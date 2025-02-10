namespace learningCSharp.OOP;

// Base Class
public abstract class Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Shape(double length, double width) // Constructor
    {
        Length = length;
        Width = width;
    }

    public abstract double CalculateArea(); // Abstract method

    public virtual string GetShapeType()
    {
        return "Unknown Shape";
    }
}

// Derived Class Rectangle
public class Rectangle : Shape
{
    public Rectangle(double length, double width) : base(length, width)
    {
    }

    public override double CalculateArea()
    {
        return Length * Width;
    }

    public override string GetShapeType()
    {
        return "Rectangle";
    }
}

// Derived Class Circle
public class Circle : Shape
{
    private const double PI = Math.PI;
    public double Radius { get; set; }

    public Circle(double radius) : base(0,0)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return PI * Radius * Radius;
    }

    public override string GetShapeType()
    {
        return "Circle";
    }
}