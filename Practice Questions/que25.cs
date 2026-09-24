using System;

class Program
{
    static void Main()
    {
        int[] arr = { 10, 25, 8, -4, 60 };

        int sum = 0;

        foreach (int num in arr)
        {
            if (num < 0)
                break;

            sum += num;
        }

        Console.WriteLine(sum);
    }
}