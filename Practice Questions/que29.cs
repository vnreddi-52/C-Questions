using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 7 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}