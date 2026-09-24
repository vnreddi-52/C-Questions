using System;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();

        int count = 0;

        foreach (char ch in word.ToLower())
        {
            if ("aeiou".Contains(ch))
                count++;
        }

        Console.WriteLine(count);
    }
}