using System;

class Program
{
    static void Main()
    {
        decimal principal = decimal.Parse(Console.ReadLine());
        decimal rate = decimal.Parse(Console.ReadLine());
        decimal years = decimal.Parse(Console.ReadLine());

        decimal interest = (principal * rate * years) / 100;
        decimal total = principal + interest;

        Console.WriteLine($"Interest: {interest}");
        Console.WriteLine($"Total: {total}");
    }
}