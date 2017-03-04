using System;

namespace _09.Refactor_Special_Numbers
{
    public class Refactor_specialNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int total = 0;
            int currentNumber = 0;
            bool isSpecial = false;

            for (int i = 1; i <= number; i++)
            {
                currentNumber = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                isSpecial = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");
                total = 0;
                i = currentNumber;
            }
        }
    }
}
