using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("1.Deposit");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Balance");
            Console.WriteLine("4.Exit");

            choice = int.Parse(Console.ReadLine());

        } while (choice != 4);

        Console.WriteLine("Goodbye");
    }
}