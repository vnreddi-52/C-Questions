using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter width: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine($"Area: {width * height}");
        Console.WriteLine($"Perimeter: {2 * (width + height)}");
    }
}