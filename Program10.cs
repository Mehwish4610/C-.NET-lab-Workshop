using System;

public abstract class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing Shape");
    }

    public virtual void Erase()
    {
        Console.WriteLine("Erasing Shape");
    }
}

public class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing Circle");
    }
}

public class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Triangle");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing Triangle");
    }
}

public class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing Square");
    }

    public override void Erase()
    {
        Console.WriteLine("Erasing Square");
    }
}

public class Program10
{
    public static void Main()
    {
        Shape[] shapes = new Shape[3];
        shapes[0] = new Circle();
        shapes[1] = new Triangle();
        shapes[2] = new Square();

        foreach (Shape shape in shapes)
        {
            shape.Draw();
            shape.Erase();
        }
    }
}
