using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] userIds={101,102,101,103,104,102,105,101};

        HashSet<int> set=new HashSet<int>();

        foreach(int id in userIds)
        {
            set.Add(id);
        }
        Console.WriteLine($"Log entries: {userIds.Length}");
        Console.WriteLine($"Unique visitors: {uniqueUsers.Count}");
        Console.WriteLine($"Repeated entries: {userIds.Length - uniqueUsers.Count}");
    }
}