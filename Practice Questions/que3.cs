using System;

class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before: a = {a}, b = {b}");

        int temp = a;
        a = b;
        b = temp;

        Console.WriteLine($"After: a = {a}, b = {b}");
    }
}