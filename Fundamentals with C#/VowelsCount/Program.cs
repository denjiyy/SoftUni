using System;
using System.Reflection;

class Program
{
    static int CountVowels(string str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        string str = Console.ReadLine()!
            .ToLower();

        Console.WriteLine(CountVowels(str));
    }
}