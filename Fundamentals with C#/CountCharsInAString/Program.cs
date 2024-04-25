using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var dictionary = new Dictionary<char, int>();

        foreach (var item in Console.ReadLine()!)
        {
            int count = 0;

            if (item == ' ')
            {
                continue;
            }

            if (dictionary.ContainsKey(item))
            {
                count = dictionary[item];
            }

            dictionary[item] = count + 1;
        }

        foreach (var item in dictionary)
        {
            Console.WriteLine(item.Key + " -> " + item.Value);
        }
    }
}