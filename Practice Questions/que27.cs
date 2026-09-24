using System;

class Program
{
    static void Main()
    {
        string password = "csharp";

        for (int i = 1; i <= 3; i++)
        {
            string input = Console.ReadLine();

            if (input == password)
            {
                Console.WriteLine("Access Granted");
                return;
            }

            Console.WriteLine("Wrong Password");
        }

        Console.WriteLine("Account Locked");
    }
}