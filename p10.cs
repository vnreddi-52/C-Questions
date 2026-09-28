for (int i = 1; i <= 3; i++)
{
    try
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(num);
        break;
    }
    catch
    {
        Console.WriteLine("Not a number");

        if (i == 3)
            Console.WriteLine("Failed after 3 attempts");
    }
}