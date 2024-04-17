using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static void MidChars(string input)
    {
        int length = input.Length;

        int middle = length / 2;

        if (length % 2 != 0)
        {
            Console.WriteLine(input[middle]);
        }
        else
        {
            int beforeMid = length / 2 - 1;
            Console.Write(input[beforeMid]);
            Console.Write(input[middle]);
        }
    }

    static void Main()
    {
        string input = Console.ReadLine()!;
        MidChars(input);
        Console.ReadLine();
    }
}