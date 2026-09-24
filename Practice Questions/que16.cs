using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        double avg = (double)sum / n;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
    }
}