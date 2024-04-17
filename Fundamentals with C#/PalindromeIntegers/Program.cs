using System;

class Program
{
    static bool IsPalindrome(int number)
    {
        string numberStr = number.ToString();
        char[] reversedChars = numberStr.ToCharArray();
        Array.Reverse(reversedChars);
        string reversedStr = new string(reversedChars);
        return numberStr == reversedStr;
    }

    static void CheckPalindrome()
    {
        while (true)
        {
            string input = Console.ReadLine()!;
            if (input == "END")
                break;

            int number = int.Parse(input);
            bool isPalindrome = IsPalindrome(number);
            Console.WriteLine(isPalindrome.ToString().ToLower());
        }
    }

    static void Main(string[] args)
    {
        CheckPalindrome();
    }
}