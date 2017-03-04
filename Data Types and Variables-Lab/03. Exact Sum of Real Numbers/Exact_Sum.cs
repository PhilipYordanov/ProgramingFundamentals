using System;

namespace _03.Exact_Sum_of_Real_Numbers
{
    public class Exact_Sum
    {
        public static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            decimal result = 0m;

            for (int i = 0; i < countOfNumbers; i++)
            {
                decimal currentNumber = decimal.Parse(Console.ReadLine());
                result += currentNumber;
            }
            Console.WriteLine(result);
        }
    }
}
