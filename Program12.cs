using System;

public interface IResizable
{
    void ResizeWidth(int width);
    void ResizeHeight(int height);
}

public class Rectangle : IResizable
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    public void ResizeWidth(int newWidth)
    {
        width = newWidth;
    }

    public void ResizeHeight(int newHeight)
    {
        height = newHeight;
    }

    public void PrintSize()
    {
        Console.WriteLine("Width: " + width + ", Height: " + height);
    }
}

public class Program12
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(100, 150);

        Console.WriteLine("Original Size:");
        rectangle.PrintSize();

        rectangle.ResizeWidth(150);
        rectangle.ResizeHeight(200);

        Console.WriteLine("\nResized Size:");
        rectangle.PrintSize();
    }
}
