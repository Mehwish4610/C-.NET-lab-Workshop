using System;

// Abstract class representing a geometric shape
public abstract class Shape
{
    // Abstract method to calculate perimeter
    public abstract double CalculatePerimeter();
}

// Concrete class representing a rectangle
public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    // Constructor for initializing length and width
    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Implementation of abstract method to calculate perimeter
    public override double CalculatePerimeter()
    {
        return 2 * (Length + Width);
    }
}

// Concrete class representing a circle
public class Circle : Shape
{
    public double Radius { get; set; }

    // Constructor for initializing the radius
    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementation of abstract method to calculate perimeter
    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Program11
{
    static void Main()
    {
        // Creating a rectangle
        Rectangle rectangle = new Rectangle(5, 7);
		Console.WriteLine("Dimensions of Rectangle: length= 7 and breadth=5");
        Console.WriteLine("Perimeter of Rectangle: " + rectangle.CalculatePerimeter());

        // Creating a circle
        Circle circle = new Circle(3);
		Console.WriteLine("Radius of Circle: 3");
        Console.WriteLine("Perimeter of Circle: " + circle.CalculatePerimeter());
    }
}
