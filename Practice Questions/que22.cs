using System;

class Program
{
    static void Main()
    {
        int[] arr = { 23, 8, 91, 45, 12 };

        int largest = arr[0];

        foreach (int num in arr)
        {
            if (num > largest)
                largest = num;
        }

        Console.WriteLine(largest);
    }
}