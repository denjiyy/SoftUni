using System;

class Program
{
    static int MinNumber(List<int> list)
    {
        int count = list.Count;
        int smallestNumber = list[0];

        for (int i = 0; i < count; i++)
        {
            if (list[i] < smallestNumber)
            {
                smallestNumber = list[i];
            }
        }

        return smallestNumber;
    }
    static void Main(string[] args)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 3; i++)
        {
            list.Add(int.Parse(Console.ReadLine()!));
        }

        Console.WriteLine(MinNumber(list));
    }
}