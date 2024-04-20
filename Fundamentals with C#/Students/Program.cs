using System;

class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);

        List<Students> students = new List<Students>();
        while (n > 0)
        {
            List<string> studentsTokens = Console.ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            students.Add(new Students(studentsTokens[0], studentsTokens[1], float.Parse(studentsTokens[2])));

            n--;
        }

        Console.WriteLine(string.Join("\n", students));
    }
}