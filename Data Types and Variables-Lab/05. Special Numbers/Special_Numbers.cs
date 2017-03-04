using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    public class Special_Numbers
    {
        public static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            int total = 0;
            int currentNumber = 0;

            bool isSpecial = false;

            for (int i = 1; i <= countOfNumbers; i++)
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
