using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int count = 0;

        do
        {
            count++;
            num /= 10;
        }
        while (num > 0);

        Console.WriteLine(count);
    }
}