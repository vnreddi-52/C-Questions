using System;

class Program
{
    static void Main()
    {
        int m1 = int.Parse(Console.ReadLine());
        int m2 = int.Parse(Console.ReadLine());
        int m3 = int.Parse(Console.ReadLine());

        double avg = (m1 + m2 + m3) / 3.0;

        Console.WriteLine($"Average: {avg:F2}");
    }
}