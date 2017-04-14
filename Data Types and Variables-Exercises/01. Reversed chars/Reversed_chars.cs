using System;

class Reversed_chars
{
    public static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        char temp = a;
        a = c;
        c = temp;

        string s = string.Join("", a, b, c);
        Console.WriteLine(s);
    }
}

