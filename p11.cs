var a = students.Where(s => s.Marks >= 75)
                .Select(s => s.Name);

var b = students.Count(s => s.Course == "CSE");

var c = students.Average(s => s.Marks);
