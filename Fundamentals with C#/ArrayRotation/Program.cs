using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Numerics;


class Program
{
    private static void RotateArr(string[] arr, int rotations)
    {
        int length = arr.Length;
        rotations %= length;

        string[] tempArr = new string[length];

        for (int i = 0; i < length; i++)
        {
            int newIndex = (i - rotations + length) % length;
            tempArr[newIndex] = arr[i];
        }

        for (int i = 0; i < length; i++)
        {
            arr[i] = tempArr[i];
        }
    }

    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine()!
            .Split();
        int n = int.Parse(Console.ReadLine()!);

        RotateArr(arr, n);

        Console.WriteLine(string.Join(' ', arr));

        Console.ReadLine();
    }
}
