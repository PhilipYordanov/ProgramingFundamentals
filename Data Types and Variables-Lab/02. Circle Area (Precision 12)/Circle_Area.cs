using System;

namespace _02.Circle_Area__Precision_12_
{
    public class Circle_Area
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double area = Math.PI * a * a;
            Console.WriteLine($"{area:F12}");
        }
    }
}
