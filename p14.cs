List<int> numbers = new() {1,2,3};

var query = numbers.Where(n => n > 1);

numbers.Add(4);

Console.WriteLine(string.Join(" ", query));