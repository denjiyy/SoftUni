using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var validCoins = new List<decimal> { 0.1m, 0.2m, 0.5m, 1m, 2m };
        var products = new Dictionary<string, decimal>
        {
            { "Nuts", 2.0m },
            { "Water", 0.7m },
            { "Crisps", 1.5m },
            { "Soda", 0.8m },
            { "Coke", 1.0m }
        };

        decimal balance = 0;
        string input;

        while ((input = Console.ReadLine()!) != "Start")
        {
            decimal coin = decimal.Parse(input);

            if (validCoins.Contains(coin))
            {
                balance += coin;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coin}");
            }
        }

        while ((input = Console.ReadLine()!) != "End")
        {
            if (products.ContainsKey(input))
            {
                decimal productPrice = products[input];

                if (balance >= productPrice)
                {
                    Console.WriteLine($"Purchased {input}");
                    balance -= productPrice;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }
        }

        Console.WriteLine($"Change: {balance:F2}");
    }
}
