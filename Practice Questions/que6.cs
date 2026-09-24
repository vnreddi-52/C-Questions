using System;

class Program
{
    static void Main()
    {
        int seconds = int.Parse(Console.ReadLine());

        int hours = seconds / 3600;
        int minutes = (seconds % 3600) / 60;
        int remSeconds = seconds % 60;

        Console.WriteLine($"{hours} h {minutes} m {remSeconds} s");
    }
}