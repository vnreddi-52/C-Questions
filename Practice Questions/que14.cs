using System;

class Program
{
    static void Main()
    {
        int units = int.Parse(Console.ReadLine());

        double bill;

        if (units <= 100)
            bill = units * 5;

        else if (units <= 200)
            bill = 100 * 5 + (units - 100) * 7;

        else
            bill = 100 * 5 + 100 * 7 + (units - 200) * 10;

        Console.WriteLine($"Bill: {bill}");
    }
}