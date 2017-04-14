using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Fast_Prime_Checker
{
    public static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());

        for (int i = 2; i <= inputNumber; i++)
        {
            bool isPrime = true;

            for (int divider = 2; divider <= Math.Sqrt(i); divider++)
            {
                if (i % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {isPrime}");
        }
    }
}

