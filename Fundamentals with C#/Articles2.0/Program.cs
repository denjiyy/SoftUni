using Articles2._0;
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()!);
        List<Article> articles = new List<Article>();

        while (n > 0)
        {
            List<string> articleTokens = Console.ReadLine()!
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            articles.Add(new Article(articleTokens[0], articleTokens[1], articleTokens[2]));

            n--;
        }

        Console.WriteLine(string.Join("\n", articles));
    }
}