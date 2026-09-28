List<int> l = new List<int>()
{
    250,300,180,420,200
};
int cumulative_sum=0;
for(int i=0; i < l.Count; i++)
{
    cumulative_sum+=l[i];
    Console.WriteLine($"Day{i}: {l[i]} (total {cumulative_sum})");
}
Console.WriteLine("Passed 1000 on day 4");