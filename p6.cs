Queue<string> tickets = new();

tickets.Enqueue("T101");
tickets.Enqueue("T102");
tickets.Enqueue("T103");
tickets.Enqueue("T104");

Console.WriteLine(tickets.Dequeue());
Console.WriteLine(tickets.Dequeue());

Console.WriteLine($"Next: {tickets.Peek()}");
Console.WriteLine($"Waiting: {tickets.Count}");