using System;

class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());

        string result = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid Day"
        };

        Console.WriteLine(result);
    }
}