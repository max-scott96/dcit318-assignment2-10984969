using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5.0);
        Rectangle rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle area: {circle.GetArea()}");      // Output: Circle area: 78.5398
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}"); // Output: Rectangle area: 24
    }
}
