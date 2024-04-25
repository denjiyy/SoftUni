Dictionary<string, List<string>> course = new Dictionary<string, List<string>>();

string input;
while ((input = Console.ReadLine()!) != "end")
{
    List<string> commands = input
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
        .ToList();

    string courseName = commands[0];
    string studentName = commands[1];

    if (course.ContainsKey(courseName))
    {
        course[courseName].Add(studentName);
    }
    else
    {
        course.Add(courseName, new List<string> { studentName });
    }
}

foreach (var item in course)
{
    Console.WriteLine($"{item.Key}: {item.Value.Count}");

    foreach (var student in item.Value)
    {
        Console.WriteLine($"-- {student}");
    }
}