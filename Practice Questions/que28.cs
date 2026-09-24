using System;

class Program
{
    static void Main()
    {
        int[] arr = { 5, -3, 12, -8, 7 };

        int sum = 0;
        int skipped = 0;

        foreach (int num in arr)
        {
            if (num < 0)
            {
                skipped++;
                continue;
            }

            sum += num;
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Skipped: {skipped}");
    }
}