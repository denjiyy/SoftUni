using System;
using System.Collections.Generic;

class Program
{
    static void FindPairsWithSum(List<int> list, int targetSum)
    {
        List<string> pairs = new List<string>();
        int pairCount = 0;

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[i] + list[j] == targetSum)
                {
                    string pair = $"{list[i]} {list[j]}";
                    pairs.Add(pair);
                    pairCount++;
                }
            }
        }

        if (pairCount > 0)
        {
            foreach (var pair in pairs)
            {
                Console.WriteLine(pair);
            }
        }
    }

    static void Main()
    {
        string input = Console.ReadLine()!;
        List<string> numbers = input
            .Split()
            .ToList();

        List<int> list = new List<int>();
        foreach (string number in numbers)
        {
            list.Add(int.Parse(number));
        }

        int targetSum = int.Parse(Console.ReadLine()!);

        FindPairsWithSum(list, targetSum);
    }
}