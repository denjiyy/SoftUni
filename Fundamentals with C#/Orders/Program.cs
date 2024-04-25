using System;

namespace Orders
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Product>();

            string input;
            while ((input = Console.ReadLine()!) != "buy")
            {
                List<string> commands = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Product product = new Product(commands[0], double.Parse(commands[1]), int.Parse(commands[2]));

                if (!dictionary.ContainsKey(commands[0]))
                {
                    dictionary.Add(commands[0], product);
                }
                else
                {
                    dictionary[commands[0]].Update(double.Parse(commands[1]), int.Parse(commands[2]));
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}