using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

class Program
{
    private static double Recursive(double x)
    {
        if (x == 1) return 1;
        else return x * Recursive(x - 1);
    }

    private static double SumDiv(double x, double y)
    {
        return x / y;
    }

    static void Main()
    {
        double x = double.Parse(Console.ReadLine()!);
        double y = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"{SumDiv(Recursive(x), Recursive(y)):f2}");
    }
}