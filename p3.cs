int[] num={3,7,3,9,7,1,3};

Dictionary<int,int> dict=new Dictionary<int, int>();

foreach(int n in num)
{
    if (dict.ContainsKey(n))
    {
        dict[n]++;
    }
    else
    {
        dict[n]=1;
    }
}
foreach(KeyValuePair<int,int> item in dict)
{
    if (item.Value > 1)
    {
        Console.WriteLine($"{item.Key} appears {item.Value} times");   
    }
}
