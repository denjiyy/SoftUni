using System;

class Program
{
    static int SumFirstTwo(int a, int b)
    {
        return a + b;
    }

    static int SubtractThird(int sum, int c)
    {
        return sum - c;
    }

    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        int c = int.Parse(Console.ReadLine()!);

        Console.WriteLine(SubtractThird(SumFirstTwo(a, b), c));
    }
}