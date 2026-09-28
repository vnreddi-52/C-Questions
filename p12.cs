var p = students
        .OrderBy(s => s.Course)
        .ThenByDescending(s => s.Marks);