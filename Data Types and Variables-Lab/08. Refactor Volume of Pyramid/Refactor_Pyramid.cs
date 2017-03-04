using System;

namespace _08.Refactor_Volume_of_Pyramid
{
    public class Refactor_Pyramid
    {
        public static void Main()
        {
            Console.Write("Length: ");
            var lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var height = double.Parse(Console.ReadLine());
            var v = (lenght * width * height) / 3;
            Console.Write($"Pyramid Volume: {v:F2}");
        }
    }
}
