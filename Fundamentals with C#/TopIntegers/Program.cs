using System;

class Program
{
    static List<int> FindTopIntegers(List<int> list)
    {
        int n = list.Count;
        List<int> topIntegers = new List<int>();
        int maxSoFar = int.MinValue;

        for (int i = n - 1; i >= 0; i--)
        {
            if (list[i] > maxSoFar)
            {
                topIntegers.Add(list[i]);
                maxSoFar = list[i];
            }
        }

        topIntegers.Reverse();
        return topIntegers;
    }

    static void Main()
    {
        string input = Console.ReadLine()!;
        string[] numbers = input
            .Split();

        List<int> list = new List<int>();
        foreach (string number in numbers)
        {
            list.Add(int.Parse(number));
        }

        List<int> topIntegers = FindTopIntegers(list);

        Console.WriteLine(string.Join(" ", topIntegers));
    }
}