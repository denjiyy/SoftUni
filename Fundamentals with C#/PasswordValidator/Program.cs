using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static List<string> ValidatePassword(string password)
    {
        List<string> errors = new List<string>();

        if (password.Length < 6 || password.Length > 10)
        {
            errors.Add("Password must be between 6 and 10 characters");
        }

        if (!password.All(ch => char.IsLetterOrDigit(ch)))
        {
            errors.Add("Password must consist only of letters and digits");
        }

        int digits = password.Count(char.IsDigit);
        if (digits < 2)
        {
            errors.Add("Password must have at least 2 digits");
        }

        return errors;
    }

    static void Main()
    {
        string password = Console.ReadLine()!;

        List<string> errors = ValidatePassword(password);

        if (errors.Any())
        {
            foreach (string error in errors)
            {
                Console.WriteLine(error);
            }
        }
        else
        {
            Console.WriteLine("Password is valid");
        }

        Console.ReadLine();
    }
}