using System;

class Program
{
    static void Main(string[] args)
    {
        string username = Console.ReadLine()!;
        string password = Reverse(username);
        int attempts = 0;

        while (attempts < 4)
        {
            string enteredPassword = Console.ReadLine()!;

            if (enteredPassword == password)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
                attempts++;
            }
        }

        Console.WriteLine($"User {username} blocked!");
    }

    static string Reverse(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}
