using System;
using System.Collections.Generic;

class Program
{
    static int FindElementWithEqualSums(List<int> list)
    {
        int n = list.Count;
        List<int> leftSum = new List<int>();
        List<int> rightSum = new List<int>();

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            leftSum.Add(sum);
            sum += list[i];
        }

        sum = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            rightSum.Insert(0, sum);
            sum += list[i];
        }

        for (int i = 0; i < n; i++)
        {
            if (leftSum[i] == rightSum[i])
            {
                return i;
            }
        }

        return -1;
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

        int index = FindElementWithEqualSums(list);

        if (index != -1)
        {
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
