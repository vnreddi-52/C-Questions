using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        char op = char.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine(a + b);
                break;

            case '-':
                Console.WriteLine(a - b);
                break;

            case '*':
                Console.WriteLine(a * b);
                break;

            case '/':
                if (b != 0)
                    Console.WriteLine(a / b);
                else
                    Console.WriteLine("Cannot divide by zero");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}