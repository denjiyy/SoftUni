using System;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Students> dictionary = new Dictionary<string, Students>();

            int n = int.Parse(Console.ReadLine()!);

            string student;
            double grade;

            for (int i = 0; i < n; i++)
            {
                student = Console.ReadLine()!;
                grade = double.Parse(Console.ReadLine()!);

                if (!dictionary.ContainsKey(student))
                {
                    dictionary.Add(student, new Students(student));
                }

                dictionary[student].Grades.Add(grade);
            }

            Dictionary<string, Students> filteredStudents = dictionary
                .Where(x => x.Value.Grades.Average() >= 4.5)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in filteredStudents)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}