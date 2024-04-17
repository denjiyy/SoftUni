using System;

class Program
{
    static bool IsTopNumber(int number)
    {
        int sumOfDigits = 0;
        bool hasOddDigit = false;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;

            if (digit % 2 != 0)
                hasOddDigit = true;

            number /= 10;
        }

        return sumOfDigits % 8 == 0 && hasOddDigit;
    }

    static void PrintTopNumbers(int n)
    {
        for (int number = 1; number <= n; number++)
        {
            if (IsTopNumber(number))
                Console.WriteLine(number);
        }
    }

    static void Main(string[] args)
    {
        int endValue = int.Parse(Console.ReadLine());

        PrintTopNumbers(endValue);
    }
}