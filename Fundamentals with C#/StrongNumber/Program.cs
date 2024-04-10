using System;

class Program
{
    static int CalculateFactorial(int number)
    {
        int result = 1;

        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }

        return result;
    }

    static bool IsStrong(int number)
    {
        int temp = number, sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += CalculateFactorial(digit);
            temp /= 10;
        }

        return sum == number;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine()!);
        Console.WriteLine(IsStrong(number) ? "yes" : "no");
    }
}