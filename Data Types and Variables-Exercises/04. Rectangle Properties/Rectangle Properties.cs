using System;

class Rectangle_Properties
{
    public static void Main()
    {
        double a, b;
        Input(out a, out b);
        Perimeter(a, b);
        Area(a, b);
        Diagonal(a, b);
    }

    static void Input(out double a, out double b)
    {
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
    }

    static void Perimeter(double a, double b)
    {
        double perimeter = 2 * (a + b);
        Console.WriteLine(perimeter);
    }

    static void Area(double a, double b)
    {
        double area = a * b;
        Console.WriteLine(area);
    }

    static void Diagonal(double a, double b)
    {
        double diagonalValue = (a * a) + (b * b);
        double diagonal = Math.Sqrt(diagonalValue);
        Console.WriteLine(diagonal);
    }
}

