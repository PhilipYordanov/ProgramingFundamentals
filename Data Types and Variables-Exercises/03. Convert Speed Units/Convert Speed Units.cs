using System;

class Convert_Speed_Units
{
    public static void Main()
    {
        uint m = UInt32.Parse(Console.ReadLine());

        byte hrs = byte.Parse(Console.ReadLine());
        byte min = byte.Parse(Console.ReadLine());
        byte sec = byte.Parse(Console.ReadLine());

        ushort time = (ushort)(hrs * 3600 + min * 60 + sec);

        float mps = (float)m / time;
        float mph = ((float)m / 1000) / ((float)time / 3600);
        float milesPerHour = ((float)m / 1609) / ((float)time / 3600);

        Console.WriteLine("{0:0.#######}", mps);
        Console.WriteLine("{0:0.#######}", mph);
        Console.WriteLine("{0:0.#######}", milesPerHour);
    }
}

