using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] stringsArrays = Console.ReadLine()!
            .Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> symbols = ExtractSymbols(stringsArrays);

        Console.WriteLine(string.Join(" ", symbols));
    }

    private static List<string> ExtractSymbols(string[] stringsArrays)
    {
        List<string> result = new List<string>();

        for (int i = stringsArrays.Length - 1; i >= 0; i--)
        {
            string[] array = stringsArrays[i]
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            result.AddRange(array);
        }

        return result;
    }
}