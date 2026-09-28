Stack<string> history = new();

history.Push("home");
history.Push("products");
history.Push("cart");
history.Push("checkout");

history.Pop();
Console.WriteLine($"Back to: {history.Peek()}");

history.Pop();
Console.WriteLine($"Back to: {history.Peek()}");