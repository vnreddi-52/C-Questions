using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int largest = a;

        if (b > largest)
            largest = b;

        if (c > largest)
            largest = c;

        Console.WriteLine($"Largest: {largest}");
    }
}