using System;

namespace _06.Triples_of_Letters
{
    public class Triples_Of_Letters
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            char letter = (char)('a' + num);

            for (char first = 'a'; first <= letter - 1; first++)
            {
                for (char second = 'a'; second <= letter - 1; second++)
                {
                    for (char third = 'a'; third <= letter - 1; third++)
                    {
                        Console.WriteLine($"{first}{second}{third}");
                    }
                }

            }
        }
    }
}
