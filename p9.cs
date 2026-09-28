try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());

    Console.WriteLine(a / b);
}
catch (FormatException)
{
    Console.WriteLine("Invalid input");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero");
}