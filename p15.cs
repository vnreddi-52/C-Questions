var report =
students.GroupBy(s => s.Course)
.Select(g => new
{
    Course = g.Key,
    Count = g.Count(),
    Avg = g.Average(s => s.Marks)
});
