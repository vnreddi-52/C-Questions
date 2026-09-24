using System;

class Program
{
    static void Main()
    {
        int marks = int.Parse(Console.ReadLine());

        if (marks < 0 || marks > 100)
            Console.WriteLine("Invalid Marks");
        else if (marks >= 90)
            Console.WriteLine("Grade A");
        else if (marks >= 75)
            Console.WriteLine("Grade B");
        else if (marks >= 60)
            Console.WriteLine("Grade C");
        else if (marks >= 40)
            Console.WriteLine("Grade D");
        else
            Console.WriteLine("Fail");
    }
}