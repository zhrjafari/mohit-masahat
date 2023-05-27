 ﻿using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the shape you want to calculate:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Square");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. trapezoid");
        Console.WriteLine("5. Ellipse");
        Console.WriteLine("6. polygon");
        Console.WriteLine("7. rectangle");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the radius of the circle: ");
                double r = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(r);
                Console.WriteLine("Area: " + circle.Getmasa());
                Console.WriteLine("Perimeter: " + circle.GetPerimeter());
                break;
            case 2:
                Console.Write("Enter the side length of the square: ");
                double s = Convert.ToDouble(Console.ReadLine());
                Square square = new Square(s);
                Console.WriteLine("masahat: " + square.GetArea());
                Console.WriteLine("mohit: " + square.GetPerimeter());
                break;
            case 3:
                Console.Write("Enter the height of the triangle: ");
                double h = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the base of the triangle: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Triangle mosalas = new Triangle(h, b);
                Console.WriteLine("masahat: " + mosalas.GetArea());
                Console.WriteLine("mohit: " + mosalas.mohit());
                break;
            case 4:
                Console.Write("Enter the height of the trapezoid: ");
                double ht = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the length of the top base of the trapezoid: ");
                double tp = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the length of the bottom base of the trapezoid: ");
                double bt = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the length of side 1 of the trapezoid: ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the length of side 2 of the trapezoid: ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Trapezoid trapezoid = new Trapezoid(ht, tp, bt, s1, s2);
                Console.WriteLine("Area: " + trapezoid.GetArea());
                Console.WriteLine("Perimeter: " + trapezoid.GetPerimeter());
                break;
            case 5:
                Console.Write("Enter the length of the major axis of the ellipse: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the length of the minor axis of the ellipse: ");
                b = Convert.ToDouble(Console.ReadLine());
                Ellipse ellipse = new Ellipse(a, b);
                Console.WriteLine("Area: " + ellipse.GetArea());
                Console.WriteLine("Perimeter: " + ellipse.GetPerimeter());
                break;
            case 6:
                Console.Write("Enter the number of sides of the polygon: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the length of each side of the polygon: ");
                double l = Convert.ToDouble(Console.ReadLine());
                Polygon polygon = new Polygon(n, l);
                Console.WriteLine("Area: " + polygon.GetArea());
                Console.WriteLine("Perimeter: " + polygon.GetPerimeter());
                break;
            case 7:
                Console.Write("Enter the length of the rectangle: ");
                double len = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double wid = Convert.ToDouble(Console.ReadLine());
                Rectangle rectangle = new Rectangle(len, wid);
                Console.WriteLine("Area: " + rectangle.GetArea());
                Console.WriteLine("Perimeter: " + rectangle.GetPerimeter());
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

}

class Circle
{
    private double radius;
    private const double pi = 3.14;

    public Circle(double r)
    {
        radius = r;
    }

    public double Getmasa()
    {
        return pi * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * pi * radius;
    }
}
class Square
{
    private double side;

    public Square(double s)
    {
        side = s;
    }

    public double GetArea()
    {
        return side * side;
    }

    public double GetPerimeter()
    {
        return 4 * side;
    }
}

class Triangle
{
    private double height;
    private double @base;

    public Triangle(double h, double b)
    {
        height = h;
        @base = b;
    }

    public double GetArea()
    {
        return 0.5 * height * @base;
    }

    public double mohit()
    {
        return @base + (2 * Math.Sqrt((height * height) + ((@base / 2) * (@base / 2))));
    }
}

class Trapezoid
{
    private double height;
    private double top;
    private double bottom;
    private double side1;
    private double side2;

    public Trapezoid(double h, double t, double b, double s1, double s2)
    {
        height = h;
        top = t;
        bottom = b;
        side1 = s1;
        side2 = s2;
    }

    public double GetArea()
    {
        return 0.5 * height * (top + bottom);
    }

    public double GetPerimeter()
    {
        return top + bottom + side1 + side2;
    }
}

class Ellipse
{
    private double majorAxis;
    private double minorAxis;
    private const double pi = 3.14;

    public Ellipse(double a, double b)
    {
        majorAxis = a;
        minorAxis = b;
    }

    public double GetArea()
    {
        return pi * majorAxis * minorAxis;
    }

    public double GetPerimeter()
    {
        return 2 * pi * Math.Sqrt((majorAxis * majorAxis + minorAxis * minorAxis) / 2);
    }

}

class Polygon
{
    private int sides;
    private double length;

    public Polygon(int s, double l)
    {
        sides = s;
        length = l;
    }

    public double GetArea()
    {
        return (sides * length * length) / (4 * Math.Tan(Math.PI / sides));
    }

    public double GetPerimeter()
    {
        return sides * length;
    }

}

class Rectangle
{
    private double l;
    private double wh;

    public Rectangle(double l, double w)
    {
        this.l = l;
        wh = w;
    }

    public double GetArea()
    {
        return l * wh;
    }

    public double GetPerimeter()
    {
        return 2 * (l + wh);
    }
}