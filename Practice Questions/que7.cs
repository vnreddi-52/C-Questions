using System;

class Program
{
    static void Main()
    {
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine($"You entered: {num}");
        }
        else
        {
            Console.WriteLine("That is not a valid number");
        }
    }
}