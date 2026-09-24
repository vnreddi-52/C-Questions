using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int reverse = 0;

        while (num > 0)
        {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }

        Console.WriteLine(reverse);
    }
}