using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

class Program
{
    private static void Matrix(int matrix)
    {
        for (int i = 0; i < matrix; i++)
        {
            int[] row = new int[matrix];
            for (int j = 0; j < matrix; j++)
            {
                row[j] = matrix;
            }
            Console.WriteLine(string.Join(" ", row));
        }
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine()!);
        Matrix(n);
        Console.ReadLine();
    }
}